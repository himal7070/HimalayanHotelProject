using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace HimalayanOnlineHotelBooking.Pages.Hotel
{

    public class BookingModel : PageModel
    {
        private readonly IRoomTypeBLL roomTypeBLL;
        private readonly IBookingBLL bookingBLL;
        private readonly IRoomBookedBLL roomBookedBLL;



        [BindProperty]
        public Booking booking { get; set; }
        public List<string> RoomTypes { get; set; }
        [BindProperty]
        public string? RoomType { get; set; }
        public int StayDuration { get; set; }

        public double TotalCost { get; set; }

        [Required(ErrorMessage = "Please select a room type")]
        public string RoomTypesSelected { get; set; }

        public string ErrorMessage { get; set; }


        public BookingModel(IRoomTypeBLL roomTypeBLL, IBookingBLL bookingBLL, IRoomBookedBLL roomBookedBLL)
        {
            this.roomTypeBLL = roomTypeBLL;
            this.bookingBLL = bookingBLL;
            this.roomBookedBLL = roomBookedBLL;

            booking = new Booking
            {
                BookingDate = DateTime.Now.Date,
                StayDuration = StayDuration,
                CheckInDate = DateTime.Now.Date,
                CheckOutDate = DateTime.Now.Date,
                BookingAmount = TotalCost,

            };


        }

        public string LoggedInUsername { get; set; }

        public int GuestId { get; private set; }

        public BookingDetailsModel BookingDetailsModel { get; set; }


        public void OnGet()
        {
            GuestId = HttpContext.Session.GetInt32("GuestId") ?? 0;
            LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;
            PopulateRoomTypeComboBox();


            if (GuestId != 0)
            {
                var bookingDetails = bookingBLL.GetBookingDetailsByGuestId(GuestId);
                if (bookingDetails != null)
                {
                    BookingDetailsModel = new BookingDetailsModel(bookingBLL)
                    {
                        BookingId = bookingDetails.BookingId
                    };
                }
            }




        }



        public IActionResult OnPostSubmitBooking(Booking booking)
        {

            int guestId = HttpContext.Session.GetInt32("GuestId") ?? 0;
            if (guestId == 0)
            {
                ModelState.AddModelError("", "You must looged in in order to submut booking.");
                return RedirectToPage("/Hotel/Account/Login");
            }
            else
            {
                try
                {

                    if (ModelState.IsValid)
                    {
                        booking.GuestId = guestId;
                        LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;



                        booking.StayDuration = CalculateDuration(booking.CheckInDate, booking.CheckOutDate);
                        booking.BookingAmount = GetTotalAmount();

                        bool bookingExists = bookingBLL.CheckBookingExists(guestId);

                        if (bookingExists)
                        {
                            ModelState.AddModelError("", "A booking already exists with this account.");
                            PopulateRoomTypeComboBox();
                            return Page();
                        }


                        bool success = bookingBLL.AddBookingByGuest(booking);

                        if (success)
                        {
                            int recentId = bookingBLL.GetRecentBookingId();

                            roomBookedBLL.InsertRoomBooking(recentId, (int)roomTypeBLL.GetRoomIdByName(Request.Form["RoomType"]));

                            int bookingId = bookingBLL.GetBookingDetailsByGuestId(guestId).BookingId;

                            string messageBody = $"Your Booking Details:\n" +
                                                 $"Booking ID: {booking.BookingId}\n" +
                                                 $"Booking Date: {booking.BookingDate}\n" +
                                                 $"Stay Duration: {booking.StayDuration}\n" +
                                                 $"Check-in Date: {booking.CheckInDate}\n" +
                                                 $"Check-out Date: {booking.CheckOutDate}";

                            string accountSid = "ACa75b443b769428cb8ef92f848329367e";
                            string authToken = "61dcdf27784ca2a43539187284c86f32";
                            string twilioPhoneNumber = "+13156182675";

                            TwilioClient.Init(accountSid, authToken);

                            var message = MessageResource.Create(
                                body: messageBody,
                                from: new Twilio.Types.PhoneNumber(twilioPhoneNumber),
                                to: new Twilio.Types.PhoneNumber("+31 6 86116079")
                            );



                            return RedirectToPage("/Hotel/BookingDetails");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Failed to add the booking. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while submitting the booking. Please try again later.");
                    ModelState.AddModelError("", ex.Message);
                }
            }


            return Page();
        }


        public IActionResult OnPostCalculateTotalCost()
        {
            if (ModelState.IsValid)
            {
                var roomtype = Request.Form["RoomType"];

                StayDuration = CalculateDuration(booking.CheckInDate, booking.CheckOutDate);

                RoomTypesSelected = roomtype.ToString();

                //int guestId = HttpContext.Session.GetInt32("GuestId") ?? 0;
                //booking.GuestId = guestId;


                TotalCost = GetTotalAmount();

                PopulateRoomTypeComboBox();

                LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;

               
            }
            return new JsonResult(new { stayDuration = StayDuration, totalCost = TotalCost });



        }


        private void PopulateRoomTypeComboBox()
        {
            RoomTypes = roomTypeBLL.GetRoomTypesForHotel();
        }

        private int CalculateDuration(DateTime checkInDate, DateTime checkOutDate)
        {
            int durationInDays = (int)(checkOutDate - checkInDate).TotalDays;
            StayDuration = Math.Max(durationInDays, 0);

            if (durationInDays <= 0)
            {
                ModelState.AddModelError("", "Invalid check-in and check-out dates. Please make sure the check-out date is after the check-in date.");
            }

            return durationInDays;

        }

        private double GetTotalAmount()
        {
            double totalAmount = 0;
            double getDateDifference = CalculateDuration(booking.CheckInDate, booking.CheckOutDate);

            if (RoomType != null)
            {
                double cost = roomTypeBLL.GetCost(RoomType);
                totalAmount = getDateDifference * cost;
            }

            return totalAmount;
        }
    }

}
