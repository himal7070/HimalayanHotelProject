using DataAccessLayer.FakeDAL;
using DataTransferClasses.Classes;
using BusinessLogicLayer.InterfacesDAL;
namespace TestProject
{
    [TestClass]
    public class BookingDALTests
    {
        private IBookingDAL bookingDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            bookingDAL = new FakeBookingDAL();
        }

        [TestMethod]
        public void AddBooking_Should_Return_True()
        {
            var booking = new Booking
            {
                BookingDate = DateTime.Now,
                StayDuration = 5,
                CheckInDate = DateTime.Now.AddDays(1),
                CheckOutDate = DateTime.Now.AddDays(6),
                BookingAmount = 500,
                GuestId = 1
            };

            var result = bookingDAL.AddBooking(booking);

            Assert.IsTrue(result, "Failed to add booking.");
        }

        [TestMethod]
        public void AddBookingByGuest_Should_Return_True()
        {
            var booking = new Booking
            {
                BookingDate = DateTime.Now,
                StayDuration = 5,
                CheckInDate = DateTime.Now.AddDays(1),
                CheckOutDate = DateTime.Now.AddDays(6),
                BookingAmount = 500,
                GuestId = 1
            };

            var result = bookingDAL.AddBookingByGuest(booking);

            Assert.IsTrue(result, "Failed to add booking by guest.");
        }

        [TestMethod]
        public void UpdateBooking_Should_Return_True()
        {
            var booking = new Booking
            {
                CheckInDate = DateTime.Now.AddDays(1),
                CheckOutDate = DateTime.Now.AddDays(6),
            };
            var bookingId = 1;

            var result = bookingDAL.UpdateBooking(booking, bookingId);

            Assert.IsTrue(result, "Failed to update booking.");
        }

        [TestMethod]
        public void DeleteBooking_Should_Return_True()
        {
            var bookingId = 1;

            var result = bookingDAL.DeleteBooking(bookingId);

            Assert.IsTrue(result, "Failed to delete booking.");
        }

        [TestMethod]
        public void ChangeBookingStatus_Should_Return_True()
        {
            var bookingId = 1;

            var result = bookingDAL.ChangeBookingStatus(bookingId);

            Assert.IsTrue(result, "Failed to change booking status.");
        }

        [TestMethod]
        public void GetRecentBookingId_Should_Return_1()
        {
            var expected = 1;

            var result = bookingDAL.GetRecentBookingId();

            Assert.AreEqual(expected, result, "Incorrect recent booking ID returned.");
        }

        [TestMethod]
        public void GetAllBookingInfo_Should_Return_Not_Null()
        {
            var result = bookingDAL.GetAllBookingInfo();

            Assert.IsNotNull(result, "Returned booking info is null.");
        }

        [TestMethod]
        public void GetAllBookingId_Should_Return_Not_Null()
        {
            var result = bookingDAL.GetAllBookingId();

            Assert.IsNotNull(result, "Returned booking IDs are null.");
        }



        [TestMethod]
        public void GetBookingDetailsByGuestId_Should_Return_Null()
        {
            int guestId = 1;

            Booking booking = bookingDAL.GetBookingDetailsByGuestId(guestId);

            Assert.IsNull(booking, "Booking details should be null.");
        }

        [TestMethod]
        public void CheckBookingExists_Should_Return_False()
        {
            int guestId = 1;

            bool bookingExists = bookingDAL.CheckBookingExists(guestId);

            Assert.IsFalse(bookingExists, "Booking should not exist for the given guest ID.");
        }

        [TestMethod]
        public void GetGuestBookings_Should_Return_EmptyList()
        {
            int guestId = 1;

            List<Booking> bookings = bookingDAL.GetGuestBookings(guestId);

            Assert.IsNotNull(bookings, "Bookings list should not be null.");
            Assert.AreEqual(0, bookings.Count, "Bookings list should be empty.");
        }


        [TestMethod]
        public void GetGuestId_ShouldReturnGuestId()
        {
            int guestId = bookingDAL.GetGuestId(123);

            Assert.AreEqual(123, guestId);
        }

        [TestMethod]
        public void GetCheckinBookingIds_ShouldReturnListOfBookingIds()
        {
            List<string> bookingIds = bookingDAL.GetCheckinBookingIds();

            Assert.IsNotNull(bookingIds);
            Assert.AreEqual(3, bookingIds.Count);
            CollectionAssert.Contains(bookingIds, "1001");
            CollectionAssert.Contains(bookingIds, "1002");
            CollectionAssert.Contains(bookingIds, "1003");
        }

        [TestMethod]
        public void GetBookingAmountById_ShouldReturnBookingAmount()
        {
            double bookingAmount = bookingDAL.GetBookingAmountById(123);

            Assert.AreEqual(100.0, bookingAmount);
        }




    }
}
