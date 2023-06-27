using DataTransferClasses.Classes;
using BusinessLogicLayer.InterfacesDAL;
namespace DataAccessLayer.FakeDAL
{
    public class FakeUserDAL : IUserDAL
    {
        private List<User> users = new List<User>();

        public bool Login(User user)
        {
            if (user.Username == "admin" && user.Password == "password")
            {
                return true;
            }
            return false;
        }

        public string CheckNewUser(User user)
        {
            if (user.Username == "newuser" && user.Password == "newpassword")
            {
                return "YES";
            }
            return "NO";
        }

        public string GenerateRandomPassword()
        {
            return "randompassword";
        }

        public bool AddNewUser(User user, int tempEmployeeId)
        {
            users.Add(user);
            return true;
        }

        public bool UpdatePassword(User user)
        {
            if (user.Username == "admin")
            {
                user.Password = "newpassword";
                return true;
            }
            return false;
        }

        public int GetEmployeeIdToken(User user)
        {
            if (user.Username == "admin" && user.Password == "password")
            {
                return 1234;
            }
            return 0;
        }

        public int GetGuestIdToken(User user)
        {
            if (user.Username == "guest" && user.Password == "password")
            {
                return 5678;
            }
            return 0;
        }

        public bool InsertGuestAndLoginData(Guest guest, User user)
        {
            if (guest.Email == "aryalhimal@gmail.com")
            {
                users.Add(user);
                return true;
            }
            return false;
        }
    }
}
