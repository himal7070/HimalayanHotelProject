using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesBLL
{
    public interface IEmployeeBLL
    {
        DataTable GetAllEmployees();
        bool AddEmployees(Employee newEmployee);
        bool UpdateEmployee(Employee employee, int employeeId);
        bool DeleteEmployee(string employeeId);
    }
}
