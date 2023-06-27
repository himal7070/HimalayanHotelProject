using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;


namespace DataAccessLayer.FakeDAL
{
    public class FakeEmployeeDAL : IEmployeeDAL
    {
        public bool AddEmployees(Employee employee, out string errorMessage)
        {
            errorMessage = null;
            return true;
        }

        public bool UpdateEmployee(Employee employee, int employeeId)
        {
            return true;
        }

        public bool DeleteEmployee(string employeeId)
        {
            return true;
        }

        public DataTable GetAllEmployees()
        {
            return new DataTable();
        }
    }
}
