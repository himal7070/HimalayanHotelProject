using DataAccessLayer.FakeDAL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace TestProject
{
    [TestClass]
    public class EmployeeDALTests
    {
        private IEmployeeDAL employeeDAL;

        [TestInitialize]
        public void SetUp()
        {
            employeeDAL = new FakeEmployeeDAL();
        }

        [TestMethod]
        public void AddEmployees_ValidEmployee_ReturnsTrue()
        {
            var employee = new Employee
            {
                FirstName = "Himal",
                LastName = "Aryal",
                Email = "aryalhimal@gmail.com",
                Phone = "123456789",
                City = "Chitwan",
                Street = "Kshetrapur",
                PostalCode = "12345",
                Country = "Nepal"
            };

            string errorMessage;
            bool result = employeeDAL.AddEmployees(employee, out errorMessage);

            Assert.IsTrue(result, "Failed to add employee.");
            Assert.IsNull(errorMessage, "Error message should be null.");
        }

        [TestMethod]
        public void UpdateEmployee_ValidEmployee_ReturnsTrue()
        {
            var employee = new Employee
            {
                EmployeeId = 1,
                FirstName = "Himal",
                LastName = "Aryal",
                Email = "aryalhimal@gmail.com",
                Phone = "123456789",
                City = "Chitwan",
                Street = "Kshetrapur",
                PostalCode = "12345",
                Country = "Nepal"
            };

            bool result = employeeDAL.UpdateEmployee(employee, employee.EmployeeId);

            Assert.IsTrue(result, "Failed to update employee.");
        }

        [TestMethod]
        public void DeleteEmployee_ValidEmployeeId_ReturnsTrue()
        {
            string employeeId = "1";

            bool result = employeeDAL.DeleteEmployee(employeeId);

            Assert.IsTrue(result, "Failed to delete employee.");
        }

        [TestMethod]
        public void GetAllEmployees_ReturnsDataTableWithEmployees()
        {
            DataTable result = employeeDAL.GetAllEmployees();

            Assert.IsNotNull(result, "Returned DataTable is null.");
           
        }
    }
}
