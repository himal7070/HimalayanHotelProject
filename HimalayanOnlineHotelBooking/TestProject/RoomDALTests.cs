using DataAccessLayer.FakeDAL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace TestProject
{
    [TestClass]
    public class RoomDALTests
    {
        private IRoomDAL roomDAL;

        [TestInitialize]
        public void SetUp()
        {          
            roomDAL = new FakeRoomDAL();
        }

        [TestMethod]
        public void AddRoom_Test()
        {
            Room room = new Room
            {
                RoomNumber = "101",
                TypeId = 1,
                Status = "Yes"
            };

            bool result = roomDAL.AddRoom(room);

            Assert.IsTrue(result, "Failed to add room.");
        }
        
        [TestMethod]
        public void UpdateRoom_Test()
        {
            Room room = new Room
            {
                RoomNumber = "101",
                TypeId = 1,
                Status = "Yes"
            };
            int roomId = 1;

            bool result = roomDAL.UpdateRoom(room, roomId);

            Assert.IsTrue(result, "Failed to update room.");
        }

        [TestMethod]
        public void UpdateRoomStatusNo_Test()
        {
            int roomId = 1;

            bool result = roomDAL.UpdateRoomStatusNo(roomId);

            Assert.IsFalse(result, "Failed to update room status to 'No'.");
        }

        [TestMethod]
        public void UpdateRoomStatusYes_Test()
        {
            int roomId = 1;

            bool result = roomDAL.UpdateRoomStatusYes(roomId);

            Assert.IsTrue(result, "Failed to update room status to 'Yes'.");
        }

        [TestMethod]
        public void GetRoomTypeName_Test()
        {

            List<string> roomTypeNames = roomDAL.GetRoomTypeName();

            Assert.IsNotNull(roomTypeNames, "Room type names should not be null.");
            Assert.AreEqual(0, roomTypeNames.Count, "Room type names count should be 0.");

        }

        [TestMethod]
        public void GetAllRooms_ReturnsAllRooms()
        {
            DataTable result = roomDAL.GetAllRooms();

            Assert.IsNotNull(result, "Returned data table should not be null.");
            Assert.AreEqual(0, result.Rows.Count, "Returned data table should have 0 rows.");
        }

        [TestMethod]
        public void DeleteRoom_Test()
        {
            int roomId = 1;

            bool result = roomDAL.DeleteRoom(roomId);

            Assert.IsTrue(result, "Failed to delete room.");
        }
    }
}
