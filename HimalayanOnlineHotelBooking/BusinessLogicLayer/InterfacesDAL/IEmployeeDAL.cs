using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IEmployeeDAL
    {
        bool AddEmployees(Employee employee, out string errorMessage);
        bool UpdateEmployee(Employee employee, int employeeId);
        bool DeleteEmployee(string employeeId);
        DataTable GetAllEmployees();

    }
}
