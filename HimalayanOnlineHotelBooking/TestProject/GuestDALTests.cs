using DataAccessLayer.FakeDAL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;
namespace TestProject
{
    [TestClass]
    public class GuestDALTests
    {
        private IGuestDAL guestDAL;

        [TestInitialize]
        public void Setup()
        {
            guestDAL = new FakeGuestDAL();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddGuest_ValidGuest_ReturnsTrue()
        {
            Guest guest = new Guest
            {
                FirstName = "Himal",
                LastName = "Aryal",
                Email = "aryalhimal@gmail.com",
                Phone = "123456789",
                PassportNumber = "ABC123",
                City = "Chitwan",
                Street = "Kshetrapur",
                PostalCode = "12345",
                Country = "Nepal"
            };


            bool result = guestDAL.AddGuest(guest);

            Assert.IsTrue(result, "Failed to add guest.");
        }

        [TestMethod]
        public void UpdateGuest_ValidGuestAndId_ReturnsTrue()
        {
            Guest guest = new Guest
            {
                FirstName = "Himal",
                LastName = "Aryal",
                Email = "aryalhimal@gmail.com",
                Phone = "123456789",
                PassportNumber = "ABC123",
                City = "Chitwan",
                Street = "Kshetrapur",
                PostalCode = "12345",
                Country = "Nepal"
            };
            string guestId = "123"; 

            bool result = guestDAL.UpdateGuest(guest, guestId);

            Assert.IsTrue(result, "Failed to update guest.");
        }

        [TestMethod]
        public void UpdateGuestReserStatus_ValidGuestId_ReturnsTrue()
        {
            string guestId = "123"; 

            bool result = guestDAL.UpdateGuestReserStatus(guestId);

            Assert.IsTrue(result, "Failed to update guest reservation status.");
        }

        [TestMethod]
        public void UpdateGuestStatus_ValidGuestId_ReturnsTrue()
        {
            int guestId = 123;

            bool result = guestDAL.UpdateGuestStatus(guestId);

            Assert.IsTrue(result, "Failed to update guest status.");
        }

        [TestMethod]
        public void DeleteGuest_ValidGuestId_ReturnsTrue()
        {
            string guestId = "123";

            bool result = guestDAL.DeleteGuest(guestId);

            Assert.IsTrue(result, "Failed to delete guest.");
        }

        [TestMethod]
        public void GetAvailableGuestIds_NoGuests_ReturnsEmptyList()
        {
            List<int> availableGuestIds = guestDAL.GetAvailableGuestIds();

            Assert.IsTrue(availableGuestIds.Count == 0, "Guest IDs list should be empty.");
        }

        [TestMethod]
        public void GetAllGuestsInfo_NoGuests_ReturnsEmptyDataTable()
        {
            DataTable dataTable = guestDAL.GetAllGuestsInfo();

            Assert.IsNotNull(dataTable, "Returned DataTable is null.");
            Assert.AreEqual(0, dataTable.Rows.Count, "Returned DataTable should be empty.");
        }

        [TestMethod]
        public void GetGuestDetails_WhenValidGuestPersonId_ReturnsGuestDetails()
        {
           

            var expectedGuest = new Guest
            {
                PassportNumber = "AB123456",
                FirstName = "himal",
                LastName = "aryal",
                Email = "himalaryal2@example.com",
                Phone = "1234567890",
                City = "Chitwan",
                PostalCode = "12345",
                Street = "eindhoven",
                Country = "nepal"
            };

            int guestPersonId = 1;

            // Act
            var result = guestDAL.GetGuestDetails(guestPersonId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedGuest.PassportNumber, result.PassportNumber);
            Assert.AreEqual(expectedGuest.FirstName, result.FirstName);
            Assert.AreEqual(expectedGuest.LastName, result.LastName);
            Assert.AreEqual(expectedGuest.Email, result.Email);
            Assert.AreEqual(expectedGuest.Phone, result.Phone);
            Assert.AreEqual(expectedGuest.City, result.City);
            Assert.AreEqual(expectedGuest.PostalCode, result.PostalCode);
            Assert.AreEqual(expectedGuest.Street, result.Street);
            Assert.AreEqual(expectedGuest.Country, result.Country);
        }

    }
}
