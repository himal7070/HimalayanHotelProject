using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesBLL
{
    public interface IDepartmentBLL
    {
        bool AddDepartment(Department department);
        bool UpdateDepartment(Department department, int departmentId);
        bool DeleteDepartment(int departmentId);
        List<string> GetDepartmentName();
        DataTable GetAllDepartments();
        int GetDepartmentId(string departmentName);
    }
}
