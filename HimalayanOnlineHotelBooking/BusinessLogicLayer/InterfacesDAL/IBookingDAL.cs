using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IBookingDAL
    {
        bool AddBooking(Booking booking);
        bool AddBookingByGuest(Booking booking);
        bool UpdateBooking(Booking booking, int bookingId);
        bool DeleteBooking(int bookingId);
        bool ChangeBookingStatus(int bookingId);
        int GetRecentBookingId();
        DataTable GetAllBookingInfo();
        List<int> GetAllBookingId();
        int GetGuestId(int bookingId);
        List<string> GetCheckinBookingIds();
        double GetBookingAmountById(int bookingId);
        List<Booking> GetGuestBookings(int guestId);

        bool CheckBookingExists(int guestId);


        Booking GetBookingDetailsByGuestId(int guestId);
    }
}
