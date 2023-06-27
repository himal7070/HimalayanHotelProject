using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;


namespace DataAccessLayer.FakeDAL
{
    public class FakeDepartmentDAL : IDepartmentDAL
    {
        public bool AddDepartment(Department department)
        {
            return true;
        }

        public bool UpdateDepartment(Department department, int departmentId)
        {
            return true;
        }

        public bool DeleteDepartment(int departmentId)
        {
            return true;
        }

        public DataTable GetAllDepartments()
        {
            return new DataTable();
        }

        public List<string> GetDepartmentName()
        {
            List<string> departmentList = new List<string>();
            departmentList.Add("HR");
            departmentList.Add("IT");
            return departmentList;
        }

        public int GetDepartmentId(string departmentName)
        {
            // Implement the desired behavior for testing
            if (departmentName == "Department 1")
                return 1;
            else if (departmentName == "Department 2")
                return 2;
            else
                return 0;
        }
    }
}
