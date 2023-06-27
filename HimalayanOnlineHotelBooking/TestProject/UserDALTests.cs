using DataAccessLayer.FakeDAL;
using DataTransferClasses.Classes;
using BusinessLogicLayer.InterfacesDAL;
namespace TestProject
{
    [TestClass]
    public class UserDALTests
    {
        private IUserDAL userDAL;

        [TestInitialize]
        public void Setup()
        {
            userDAL = new FakeUserDAL();
        }

        [TestMethod]
        public void Login_TestValidCredentials_ReturnsTrue()
        {
            User user = new User
            {
                Username = "admin",
                Password = "password"
            };

            bool isAuthenticated = userDAL.Login(user);

            Assert.IsTrue(isAuthenticated, "Login should succeed with valid credentials.");
        }

        [TestMethod]
        public void Login_InvalidCredentials_ReturnsFalse()
        {
            User user = new User
            {
                Username = "himal",
                Password = "aryal"
            };

            bool isAuthenticated = userDAL.Login(user);

            Assert.IsFalse(isAuthenticated, "Login should fail with invalid credentials.");
        }

        [TestMethod]
        public void CheckNewUser_ExistingUser_ReturnsNo()
        {
            User user = new User
            {
                Username = "admin",
                Password = "password"
            };

            string newUser = userDAL.CheckNewUser(user);

            Assert.AreEqual("NO", newUser, "Existing user should be indicated as 'NO'.");
        }

        [TestMethod]
        public void CheckNewUser_NewUser_ReturnsYes()
        {
            User user = new User
            {
                Username = "newuser",
                Password = "newpassword"
            };

            string newUser = userDAL.CheckNewUser(user);

            Assert.AreEqual("YES", newUser, "New user should be indicated as 'YES'.");
        }

        [TestMethod]
        public void GenerateRandomPassword_ReturnsNonEmptyString()
        {
            string randomPassword = userDAL.GenerateRandomPassword();

            Assert.IsFalse(string.IsNullOrEmpty(randomPassword), "Random password should not be empty.");
        }

        [TestMethod]
        public void AddNewUser_ValidUser_ReturnsTrue()
        {
            User user = new User
            {
                Username = "himal",
                Password = "aryal"
            };

            bool isAdded = userDAL.AddNewUser(user, 123);

            Assert.IsTrue(isAdded, "New user should be added successfully.");
        }

        [TestMethod]
        public void UpdatePassword_ValidUser_ReturnsTrue()
        {
            User user = new User
            {
                Username = "admin",
                Password = "password"
            };

            bool isUpdated = userDAL.UpdatePassword(user);

            Assert.IsTrue(isUpdated, "Password should be updated successfully.");
            Assert.AreEqual("newpassword", user.Password, "Password should be updated to 'newpassword'.");
        }

        [TestMethod]
        public void GetEmployeeIdToken_ValidUser_ReturnsEmployeeId()
        {
            User user = new User
            {
                Username = "admin",
                Password = "password"
            };

            int employeeIdToken = userDAL.GetEmployeeIdToken(user);

            Assert.AreEqual(1234, employeeIdToken, "Returned employee ID token should match the expected value.");
        }

        [TestMethod]
        public void GetGuestIdToken_ValidUser_ReturnsGuestId()
        {
            User user = new User
            {
                Username = "guest",
                Password = "password"
            };

            int guestIdToken = userDAL.GetGuestIdToken(user);

            Assert.AreEqual(5678, guestIdToken, "Returned guest ID token should match the expected value.");
        }

        [TestMethod]
        public void InsertGuestAndLoginData_ValidData_ReturnsTrue()
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

            User user = new User
            {
                Username = "himal",
                Password = "password"
            };

            bool isInserted = userDAL.InsertGuestAndLoginData(guest, user);

            Assert.IsTrue(isInserted, "Guest and login data should be inserted successfully.");
        }

    }
}
