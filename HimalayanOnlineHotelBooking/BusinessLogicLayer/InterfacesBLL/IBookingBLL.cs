using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesBLL
{
    public interface IBookingBLL
    {
        DataTable GetAllBooking();
        bool AddBooking(Booking booking);
        bool AddBookingByGuest(Booking booking);
        bool UpdateBooking(Booking booking, int bookingId);
        bool DeleteBooking(int bookingId);
        bool ChangeBookingStatus(int bookingId);
        int GetRecentBookingId();
        List<int> GetAllBookingId();
        int GetGuestId(int bookingId);
        List<string> GetCheckinBookingIds();
        double GetBookingAmountById(int bookingId);
        int CalculateDuration(DateTime checkInDate, DateTime checkOutDate);

        int CalculateDiscountPercentage(int guestId);
        bool CheckBookingExists(int guestId);
        //int GetBookingIdByGuestId(int guestId);

        Booking GetBookingDetailsByGuestId(int guestId);



    }
}
