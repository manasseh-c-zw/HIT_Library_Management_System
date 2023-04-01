using Dapper;
using HIT_Library_Manager_Lib.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace HIT_Library_Manager_Lib
{
    /// <summary>
    /// This is a class to connect to the DB
    /// Contains all the data access methods needed in the project
    /// </summary>
    public class SQliteConnector
    {
        /// <summary>
        /// To retrieve connection string from the app.config file
        /// </summary>
        /// <returns>Connection String</returns>
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }


        #region UserModel Methods

        /// <summary>
        /// To add a user into the DB
        /// </summary>
        /// <param name="user"> this is the user to be added</param>
        public static void AddUser(UserModel user)
        {


            // Hash the user's password using bcrypt with the generated salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password, 10);

            // Define a SQL statement to insert the user into the database
            string sql = @"
            INSERT INTO Users (Username, Password)
            VALUES (@Username, @Password);
            ";

            // Create a new SQLite connection object and open the connection
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {

                // Execute the SQL command to insert the user into the database
                connection.Execute(sql, new { Username = user.Username, Password = hashedPassword });

            }
        }


        /// <summary>
        /// Authenticates a user on login
        /// </summary>
        /// <param name="username">The username entered by the user</param>
        /// <param name="password">The corresponding password for the entered username</param>
        /// <returns>True if authentication is successful</returns>
        public static bool AuthenticateUser(string username, string password)
        {
            try
            {
                var user = new UserModel();
                using (var connection = new SQLiteConnection(LoadConnectionString()))
                {
                    // retrieve the user from the database
                    user = connection.QuerySingleOrDefault<UserModel>(
                       "SELECT Username, Password FROM users WHERE username = @username", new { username });
                }

                // if the user doesn't exist, authentication fails
                if (user == null)
                {
                    return false;
                }

                // verify the password using Bcrypt
                return BCrypt.Net.BCrypt.Verify(password, user.Password);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// Updates a user's password
        /// </summary>
        /// <param name="username">the user whos password is to be updated</param>
        /// <param name="oldPassword">the existing password, for verification</param>
        /// <param name="newPassword">the password to overwrite the existing</param>
        /// <exception cref="ArgumentException"></exception>
        public void UpdateUserPassword(string username, string oldPassword, string newPassword)
        {

            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                // Retrieve the user's hashed password and salt from the database
                var user = connection.QuerySingleOrDefault<UserModel>("SELECT * FROM Users WHERE Username = @Username", new { Username = username });
                if (user == null)
                {
                    // User not found
                    throw new ArgumentException("User not found.");
                }


                if (BCrypt.Net.BCrypt.Verify(oldPassword, user.Password))
                {
                    // Old password doesn't match
                    throw new ArgumentException("Old password is incorrect.");
                }

                // Generate a new salt and hash the new password with it
                string newHashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                // Update the user's password and salt in the database
                connection.Execute("UPDATE Users SET HashedPassword = @HashedPassword WHERE Id = @Id", new { HashedPassword = newHashedPassword, Id = user.Id });
            }
        }


        /// <summary>
        /// Retrieves the list of all Users from the Database
        /// </summary>
        /// <returns>List of UserModel</returns>
        public static List<UserModel> LoadUsers()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                var output = cnn.Query<UserModel>("SELECT * FROM Users", null);
                return output.ToList();
            }
        }

        #endregion



    }
}
