using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HimalayanOnlineHotelBooking.Pages.Hotel
{
    public class BookingDetailsModel : PageModel
    {
        private readonly IBookingBLL bookingBLL;

        public BookingDetailsModel(IBookingBLL bookingBLL)
        {
            this.bookingBLL = bookingBLL;
        }

        public string LoggedInUsername { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }

        public void OnGet()
        {
            LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;
            int guestId = HttpContext.Session.GetInt32("GuestId") ?? 0;
            Booking = bookingBLL.GetBookingDetailsByGuestId(guestId);
            BookingId = Booking?.BookingId ?? 0;
        }
    }
}
