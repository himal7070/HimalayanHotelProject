using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace BusinessLogicLayer.BLL
{
    public class BookingBLL : IBookingBLL
    {

        private IBookingDAL bookingDAL;

        public BookingBLL(IBookingDAL bookingDAL)
        {
            this.bookingDAL = bookingDAL;
        }

        public int CalculateDiscountPercentage(int guestId)
        {
            try
            {
                List<Booking> bookings = bookingDAL.GetGuestBookings(guestId); // retrieve the guest's booking history

                DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);
                List<Booking> recentBookings = FilterBookingsWithinPeriod(bookings, sixMonthsAgo, DateTime.Now); // filter bookings within the past 6 months

                int bookingCount = CountBookingsByGuestId(recentBookings, guestId); // count bookings for the guest ID within the filtered period

                if (bookingCount >= 3)
                {
                    return 20; //apply 20% discount
                }
                else
                {
                    return 0; //no discount
                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        private int CountBookingsByGuestId(List<Booking> bookings, int guestId)
        {
            int count = 0;

            try
            {
                foreach (Booking booking in bookings)
                {
                    if (booking.GuestId == guestId)
                    {
                        count++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }



            return count;
        }

        private List<Booking> FilterBookingsWithinPeriod(List<Booking> bookings, DateTime startDate, DateTime endDate)
        {
            List<Booking> filteredBookings = new List<Booking>();

            try
            {
                foreach (Booking booking in bookings)
                {
                    if (booking.BookingDate >= startDate && booking.BookingDate <= endDate)
                    {
                        filteredBookings.Add(booking);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }


            return filteredBookings;
        }


        public Booking GetBookingDetailsByGuestId(int guestId)
        {
            try
            {
                Booking booking = bookingDAL.GetBookingDetailsByGuestId(guestId);
                return booking;
            }
            catch (Exception)
            {
                throw;
            }
          
        }

        public bool CheckBookingExists(int guestId)
        {
            try
            {
                return bookingDAL.CheckBookingExists(guestId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetAllBooking()
        {
            try
            {
                return bookingDAL.GetAllBookingInfo();
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public bool AddBooking(Booking booking)
        {
            try
            {
                return bookingDAL.AddBooking(booking);
            }
            catch (Exception)
            {
                throw;
            }
           
           
        }

        public bool AddBookingByGuest(Booking booking)
        {
            try
            {
                return bookingDAL.AddBookingByGuest(booking);
            }
            catch (Exception)
            {
                throw;
            }
          
        }

        public bool UpdateBooking(Booking booking, int bookingId)
        {
            try
            {
                return bookingDAL.UpdateBooking(booking, bookingId);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public bool DeleteBooking(int bookingId)
        {
            try
            {
                return bookingDAL.DeleteBooking(bookingId);
            }
            catch (Exception)
            {
                throw;
            }
         
        }

        public bool ChangeBookingStatus(int bookingId)
        {
            try
            {
                return bookingDAL.ChangeBookingStatus(bookingId);
            }
            catch (Exception)
            {
                throw;
            }
          
        }

        public int GetRecentBookingId()
        {
            try
            {
                return bookingDAL.GetRecentBookingId();
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public List<int> GetAllBookingId()
        {
            try
            {
                return bookingDAL.GetAllBookingId();
            }
            catch (Exception)
            {
                throw;
            }
           
           
        }

        public int GetGuestId(int bookingId)
        {
            try
            {
                return bookingDAL.GetGuestId(bookingId);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<string> GetCheckinBookingIds()
        {
            try
            {
                return bookingDAL.GetCheckinBookingIds();
            }
            catch (Exception)
            {
                throw;
            }
          
        }

        public double GetBookingAmountById(int bookingId)
        {
            try
            {
                return bookingDAL.GetBookingAmountById(bookingId);
            }
            catch (Exception)
            {
                throw;
            }
            
        }


        public int CalculateDuration(DateTime checkInDate, DateTime checkOutDate)
        {          
            try
            {
                int durationInDays = (int)(checkOutDate - checkInDate).TotalDays;
                return durationInDays;
            }
            catch (Exception)
            {
                throw;
            }
        }


      
     

    }
}
