using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace BusinessLogicLayer.BLL
{
    public class EmployeeBLL : IEmployeeBLL
    {
        private IEmployeeDAL employeeDAL;

        public EmployeeBLL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }

        public DataTable GetAllEmployees()
        {
            try
            {
                return employeeDAL.GetAllEmployees();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AddEmployees(Employee newEmployee)
        {
            try
            {
                string errorMessage;
                bool success = employeeDAL.AddEmployees(newEmployee, out errorMessage);

                if (!success)
                {
                    throw new Exception(errorMessage);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
            return true;
          
        }

        public bool UpdateEmployee(Employee employee, int employeeId)
        {
            try
            {
                return employeeDAL.UpdateEmployee(employee, employeeId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteEmployee(string employeeId)
        {
            try
            {
                return employeeDAL.DeleteEmployee(employeeId);
            }
            catch (Exception) { throw; }
        }



    }
}
