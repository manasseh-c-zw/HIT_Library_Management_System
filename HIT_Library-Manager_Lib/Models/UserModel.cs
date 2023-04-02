namespace HIT_Library_Manager_Lib.Models
{
    /// <summary>
    /// Represents a single user
    /// </summary>
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Auto property displays the user id and username as one string
        public string UserDetails => $"{Id} {Username}";

        public UserModel()
        {

        }

        //A constructor to initialize the book object by parsing the parameters
        public UserModel(string username, string password)
        {

            Username = username;
            Password = password;
        }
    }
}
