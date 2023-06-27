using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;
using BusinessLogicLayer.BLL;

namespace DataAccessLayer.FakeDAL
{
    public class FakeBookingDAL : IBookingDAL
    {

        public int GetGuestId(int bookingId)
        {
            return 123;
        }

        public List<string> GetCheckinBookingIds()
        {
            List<string> bookingIds = new List<string> { "1001", "1002", "1003" };
            return bookingIds;
        }

        public double GetBookingAmountById(int bookingId)
        {
            return 100.0;
        }



        public Booking GetBookingDetailsByGuestId(int guestId)
        {
            return null;
        }

        public bool CheckBookingExists(int guestId)
        {
            return false;
        }

        public List<Booking> GetGuestBookings(int guestId)
        {
            return new List<Booking>();
        }


        public bool AddBooking(Booking booking)
        {
            return true;
        }

        public bool AddBookingByGuest(Booking booking)
        {
            return true;
        }

        public bool UpdateBooking(Booking booking, int bookingId)
        {
            return true;
        }

        public bool DeleteBooking(int bookingId)
        {
            return true;
        }

        public bool ChangeBookingStatus(int bookingId)
        {
            return true;
        }

        public int GetRecentBookingId()
        {
            return 1;
        }

        public DataTable GetAllBookingInfo()
        {
            return new DataTable();
        }

        public List<int> GetAllBookingId()
        {
            List<int> bookingIds = new List<int> { 1, 2, 3 };
            return bookingIds;
        }

        public static explicit operator FakeBookingDAL(BookingBLL v)
        {
            throw new NotImplementedException();
        }
    }
}
