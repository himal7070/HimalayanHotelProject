using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferClasses.Classes
{
    public class Room
    {

        private int roomId;
        private string roomNumber;
        private int roomTypeId;
        private string status;


      
        public string RoomNumber 
        {
            get => roomNumber;
            set => roomNumber = value;
        }

        public int TypeId 
        { 
            get => roomTypeId;
            set => roomTypeId = value;
        }
        public string Status 
        { 
            get => status; 
            set => status = value; 
        }
       
    }
}
