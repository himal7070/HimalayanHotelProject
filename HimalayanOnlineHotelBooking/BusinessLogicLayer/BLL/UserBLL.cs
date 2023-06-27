using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using BusinessLogicLayer.InterfacesDAL;

namespace BusinessLogicLayer.BLL
{
    public class UserBLL : IUserBLL
    {
        private IUserDAL userDAL;

        public UserBLL(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public bool AddNewUser(User user, int tempEmployeeId)
        {
            try
            {
                return userDAL.AddNewUser(user, tempEmployeeId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GenerateRandomPassword()
        {
            try
            {
                return userDAL.GenerateRandomPassword();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Login(User user)
        {
            try
            {
                return userDAL.Login(user);
            }
            catch (Exception) { throw; }
        }

        public string CheckNewUser(User user)
        {
            try
            {
                string isNewUser = userDAL.CheckNewUser(user);
                return isNewUser.Trim();
            }
            catch (Exception) { throw; }
        }

        public bool UpdatePassword(User user)
        {
            try
            {
                return userDAL.UpdatePassword(user);
            }
            catch (Exception) { throw; }
        }

        public int GetEmployeeIdToken(User user)
        {
            try
            {
                return userDAL.GetEmployeeIdToken(user);
            }
            catch (Exception) { throw; }
        }

        public int GetGuestIdToken(User user)
        {
            try
            {
                return userDAL.GetGuestIdToken(user);
            }
            catch (Exception) { throw; }
        }

        public bool InsertGuestAndLoginData(Guest guest, User user)
        {
            try
            {
                return userDAL.InsertGuestAndLoginData(guest, user);
            }
            catch (Exception)
            {
                throw;
            }
           
        }


    }
}
