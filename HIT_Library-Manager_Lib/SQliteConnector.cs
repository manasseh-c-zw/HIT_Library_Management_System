using Dapper;
using HIT_Library_Manager_Lib.Models;
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
        /// To add a user into the DB
        /// </summary>
        /// <param name="user"> this is the user to be added</param>
        public static void AddUser(UserModel user)
        {
            // Generate a salt value for the password hash
            var salt = BCrypt.Net.BCrypt.GenerateSalt(16);

            // Hash the user's password using bcrypt with the generated salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password, salt);

            // Define a SQL statement to insert the user into the database
            string sql = @"
            INSERT INTO Users (Username, Password, Salt)
            VALUES (@Username, @Password, @Salt);
            ";

            // Create a new SQLite connection object and open the connection
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                // Execute the SQL command to insert the user into the database
                connection.Execute(sql, new { Username = user.Username, Password = hashedPassword, Salt = salt });

                // Close the connection
                connection.Close();
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
            var user = new UserModel();
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                // retrieve the user from the database
                user = connection.QuerySingleOrDefault<UserModel>(
                   "SELECT * FROM users WHERE username = @username", new { username });
            }


            // if the user doesn't exist, authentication fails
            if (user == null)
            {
                return false;
            }

            // verify the password using Bcrypt
            return BCrypt.Net.BCrypt.Verify(password, user.Password);
        }



        /// <summary>
        /// Retrieves the list of all Users from the Database
        /// </summary>
        /// <returns>List of UserModel</returns>
        public static List<UserModel> LoadUsers()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                var output = cnn.Query<UserModel>("SELECT * FROM Users", null);
                return output.ToList();
            }
        }



        /// <summary>
        /// To retrieve connectoin string from the app.config file
        /// </summary>
        /// <returns>Connection String</returns>
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
    }
}
