using DataAccessLayer.FakeRoomTypeDAL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;
namespace TestProject
{
    [TestClass]
    public class RoomTypeDALTests
    {
        private IRoomTypeDAL roomTypeDAL;

        [TestInitialize]
        public void SetUp()
        {
            //instance of the fake DAL for testing
            roomTypeDAL = new FakeRoomTypeDAL();
        }


        [TestMethod]
        public void AddRoomType_Test()
        {
            RoomType roomType = new RoomType("Single", 100, "Single room");
         
            bool result = roomTypeDAL.AddRoomType(roomType);

            Assert.IsTrue(result, "Failed to add room type.");

        }

        [TestMethod]
        public void GetAllRoomTypes_Test()
        {
            DataTable result = roomTypeDAL.GetAllRoomTypes();

            Assert.IsNotNull(result, "Returned data table should not be null.");
            Assert.AreEqual(0, result.Rows.Count, "Returned data table should have 0 rows.");

        }

        [TestMethod]
        public void UpdateRoomType_Test()
        {
            RoomType roomType = new RoomType("Single", 100, "Single room");

            int roomTypeId = 1;

            bool result = roomTypeDAL.UpdateRoomType(roomType, roomTypeId);

            Assert.IsTrue(result, "Failed to update room type.");
        }

        [TestMethod]
        public void DeleteRoomType_Test()
        {
            string roomTypeId = "1";

            bool result = roomTypeDAL.DeleteRoomType(roomTypeId);

            Assert.IsTrue(result, "Failed to delete room type.");
        }

        [TestMethod]
        public void GetRoomTypeIdByName_Test()
        {
            string name = "Single";

            int result = roomTypeDAL.GetRoomTypeIdByName(name);

            Assert.AreEqual(0, result, "Failed to get room type ID by name.");
        }

        [TestMethod]
        public void GetRoomIdByName_Test()
        {
            string name = "Single";

            int result = roomTypeDAL.GetRoomIdByName(name);

            Assert.AreEqual(0, result, "Failed to get room ID by name.");
        }

        [TestMethod]
        public void GetDistinctRoomTypesForHotel_Test()
        {
            List<string> result = roomTypeDAL.GetDistinctRoomTypesForHotel();

            Assert.IsNotNull(result, "Returned room types list should not be null.");
            Assert.AreEqual(0, result.Count, "Returned room types list should have 0 items.");
        }

        [TestMethod]
        public void GetCost_Test()
        {
            string name = "Single";

            double result = roomTypeDAL.GetCost(name);

            Assert.AreEqual(0, result, "Failed to get room type cost.");
        }

    }
}