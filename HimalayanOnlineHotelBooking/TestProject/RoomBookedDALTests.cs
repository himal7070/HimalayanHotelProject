using DataAccessLayer.FakeDAL;
using BusinessLogicLayer.InterfacesDAL;

namespace TestProject
{
    [TestClass]
    public class RoomBookedDALTests
    {
        private IRoomBookedDAL roomBookedDAL;

        [TestInitialize]
        public void Initialize()
        {
            roomBookedDAL = new FakeRoomBookedDAL();
        }

        [TestMethod]
        public void InsertRoomBooked_ShouldInsertRoomBooking()
        {
            int roomId = 1;
            int bookingId = 1;

            roomBookedDAL.InsertRoomBooked(roomId, bookingId);

            int result = roomBookedDAL.GetRoomId(bookingId);
            Assert.AreEqual(roomId, result, "Failed to insert room booking.");
        }

        [TestMethod]
        public void GetRoomId_WhenBookingIdExists_ShouldReturnRoomId()
        {
            int roomId = 1;
            int bookingId = 1;
            roomBookedDAL.InsertRoomBooked(roomId, bookingId);

            int result = roomBookedDAL.GetRoomId(bookingId);

            Assert.AreEqual(roomId, result, "Returned room ID does not match the expected value.");
        }

        [TestMethod]
        public void GetRoomId_WhenBookingIdDoesNotExist_ShouldReturnDefaultValue()
        {
            int bookingId = 1;

            int result = roomBookedDAL.GetRoomId(bookingId);

            Assert.AreEqual(0, result, "Returned room ID should be 0.");
        }
    }
}
