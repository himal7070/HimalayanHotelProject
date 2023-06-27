using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IUserDAL
    {
        bool Login(User user);
        string CheckNewUser(User user);
        string GenerateRandomPassword();
        bool AddNewUser(User user, int tempEmployeeId);
        bool UpdatePassword(User user);
        int GetEmployeeIdToken(User user);
        int GetGuestIdToken(User user);
        bool InsertGuestAndLoginData(Guest guest, User user);
    }
}
