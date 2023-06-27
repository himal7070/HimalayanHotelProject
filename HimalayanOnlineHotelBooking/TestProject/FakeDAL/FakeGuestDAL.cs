using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;


namespace DataAccessLayer.FakeDAL
{
    public class FakeGuestDAL : IGuestDAL
    {
        public bool AddGuest(Guest guest)
        {
            return true; 
        }

        public bool UpdateGuest(Guest guest, string guestId)
        {
            return true; 
        }

        public bool UpdateGuestReserStatus(string guestId)
        {
            return true;
        }

        public bool UpdateGuestStatus(int guestId)
        {
            return true;
        }

        public bool DeleteGuest(string strGuestId)
        {
            return true; 
        }

        public List<int> GetAvailableGuestIds()
        {
            return new List<int>();
        }

        public DataTable GetAllGuestsInfo()
        {
            return new DataTable(); 
        }

        public Guest GetGuestDetails(int guestPersonId)
        {
            var fakeGuest = new Guest
            {
                PassportNumber = "AB123456",
                FirstName = "himal",
                LastName = "aryal",
                Email = "himalaryal2@example.com",
                Phone = "1234567890",
                City = "Chitwan",
                PostalCode = "12345",
                Street = "eindhoven",
                Country = "nepal"
            };

            return fakeGuest;
        }
    }
}
