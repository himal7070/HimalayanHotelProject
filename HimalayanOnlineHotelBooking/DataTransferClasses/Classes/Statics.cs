using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferClasses.Classes
{
    public class Statics
    {
        public static int maxId;
        
        
        public static int tempEmployeeId;


        public static void SetTempEmplId(int id)
        {
            tempEmployeeId = id;
        }



        public static string employeeNameAndId;

        public static void EmployeeNameId(int id, string name)
        {
            employeeNameAndId = name + id;
        }


        public static string username;

        public static void SetUsername(string str)
        {
            username = str;
        }


        public static string password;
        public static void SetPassword(string str)
        {
            password = str;
        }


        public static int employeeIdToken;

        public static void SetEmployeeId(int id)
        {
            employeeIdToken = id;
        }

        public static int guestIdToken;

        public static void SetGuestId(int id)
        {
            guestIdToken = id;
        }


        public static int tempGuestId;


        public static void SetTempGuestId(int id)
        {
            tempGuestId = id;
        }
    }
}
