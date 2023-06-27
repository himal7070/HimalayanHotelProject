using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace BusinessLogicLayer.BLL
{
    public class DepartmentBLL : IDepartmentBLL
    {
        private IDepartmentDAL departmentDAL;

        public DepartmentBLL(IDepartmentDAL departmentDAL)
        {
            this.departmentDAL = departmentDAL;
        }

        public bool AddDepartment(Department department)
        {
            try
            {
                return departmentDAL.AddDepartment(department);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateDepartment(Department department, int departmentId)
        {
            try
            {
                return departmentDAL.UpdateDepartment(department, departmentId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteDepartment(int departmentId)
        {
            try
            {
                return departmentDAL.DeleteDepartment(departmentId);
            }
            catch (Exception) { throw; }
        }

        public List<string> GetDepartmentName()
        {
            try
            {
                return departmentDAL.GetDepartmentName();
            }
            catch (Exception) { throw; }
        }

        public DataTable GetAllDepartments()
        {
            try
            {
                return departmentDAL.GetAllDepartments();
            }
            catch (Exception) { throw; }
        }

        public int GetDepartmentId(string departmentName)
        {
            try
            {
                return departmentDAL.GetDepartmentId(departmentName);
            }
            catch (Exception) { throw; }
        }
    }
}
