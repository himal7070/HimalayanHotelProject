using DataAccessLayer.FakeDAL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace TestProject
{
    [TestClass]
    public class DepartmentDALTests
    {
        private IDepartmentDAL departmentDAL;

        [TestInitialize]
        public void Setup()
        {
            departmentDAL = new FakeDepartmentDAL();
        }

        [TestMethod]
        public void AddDepartment_ValidDepartment_ReturnsTrue()
        {
            Department department = new Department
            {
                DepartmentName = "Test Department",
                DepartmentDescription = "Test Description",
                Salary = 3000
            };

            bool result = departmentDAL.AddDepartment(department);

            Assert.IsTrue(result, "Failed to add department.");
        }

        [TestMethod]
        public void UpdateDepartment_ValidDepartment_ReturnsTrue()
        {
            Department department = new Department
            {
                DepartmentName = "Test Department",
                DepartmentDescription = "Test Description",
                Salary = 3000
            };
            int departmentId = 1;

            bool result = departmentDAL.UpdateDepartment(department, departmentId);

            Assert.IsTrue(result, "Failed to update department.");
        }

        [TestMethod]
        public void DeleteDepartment_ValidDepartmentId_ReturnsTrue()
        {
            int departmentId = 1;

            bool result = departmentDAL.DeleteDepartment(departmentId);

            Assert.IsTrue(result, "Failed to delete department.");
        }

        [TestMethod]
        public void GetAllDepartments_ReturnsDataTableWithDepartments()
        {
            DataTable result = departmentDAL.GetAllDepartments();

            Assert.IsNotNull(result, "Returned DataTable is null.");
       

        }

        [TestMethod]
        public void GetDepartmentName_ReturnsListOfDepartmentNames()
        {
            var result = departmentDAL.GetDepartmentName();

            Assert.IsNotNull(result, "Returned department names list is null.");
            Assert.AreEqual(2, result.Count, "Returned department names count is incorrect.");

        }

        [TestMethod]
        public void GetDepartmentId_ExistingDepartmentName_ReturnsDepartmentId()
        {
            string departmentName = "Department 1";

            int result = departmentDAL.GetDepartmentId(departmentName);

            Assert.AreEqual(1, result, "Returned department ID is incorrect.");
        }

        [TestMethod]
        public void GetDepartmentId_NonExistingDepartmentName_ReturnsZero()
        {
            string departmentName = "Non-existing Department";

            int result = departmentDAL.GetDepartmentId(departmentName);

            Assert.AreEqual(0, result, "Returned department ID is incorrect."); 
        }
    }
}
