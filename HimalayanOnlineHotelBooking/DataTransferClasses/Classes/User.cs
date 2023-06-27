

using System.ComponentModel.DataAnnotations;

namespace DataTransferClasses.Classes
{
    public class User 
    {
       
        private int userID;
        private string username;
        private string password;

      

        public int UserID
        {
            get => userID;
            set => userID = value;
        }
        [Required(ErrorMessage = "Username is required.")]
        public string Username
        {
            get => username;
            set => username = value;
        }
        [Required(ErrorMessage = "Password is required.")]
        public string Password
        {
            get => password;
            set => password = value;
        }

    
    }
}
