using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IDepartmentDAL
    {
        bool AddDepartment(Department department);
        bool UpdateDepartment(Department department, int departmentId);
        bool DeleteDepartment(int departmentId);
        DataTable GetAllDepartments();
        List<string> GetDepartmentName();
        int GetDepartmentId(string departmentName);
    }
}
