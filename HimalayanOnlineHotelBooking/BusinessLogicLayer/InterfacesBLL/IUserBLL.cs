using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesBLL
{
    public interface IUserBLL
    {
        bool AddNewUser(User user, int tempEmployeeId);
        string GenerateRandomPassword();
        bool Login(User user);
        string CheckNewUser(User user);
        bool UpdatePassword(User user);
        int GetEmployeeIdToken(User user);
        int GetGuestIdToken(User user);
        bool InsertGuestAndLoginData(Guest guest, User user);
    }
}
