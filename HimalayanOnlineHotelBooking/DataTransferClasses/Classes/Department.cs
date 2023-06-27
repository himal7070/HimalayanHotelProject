using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferClasses.Classes
{
    public class Department
    {
        private int departmentId;
        private string departmentName;
        private string departmentDescription;
        private float salary;


        //public Department(string departmentName, string departmentDescription, float salary)
        //{
            
        //    this.departmentName = departmentName;
        //    this.departmentDescription = departmentDescription;
        //    this.salary = salary;
        //}

        public int DepartmentId
        {
            get => departmentId;
            set => departmentId = value;
        }

        public string DepartmentName
        {
            get => departmentName;
            set => departmentName = value;
        }

        public string DepartmentDescription
        {
            get => departmentDescription;
            set => departmentDescription = value;
        }

        public float Salary
        {
            get => salary;
            set => salary = value;
        }

    }
}
