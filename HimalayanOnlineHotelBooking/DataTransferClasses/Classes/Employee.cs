using System.Security.Cryptography;

namespace DataTransferClasses.Classes
{
    public class Employee
    {
             
        private int employeeId;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string city;
        private string postalCode;
        private string street;
        private string country;
        private int departmentId;
        private string designation;
        private DateTime joiningDate;
        


        
        public int EmployeeId 
        { 
            get => employeeId;
            set => employeeId = value; 
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }
        public string PostalCode
        {
            get => postalCode;
            set => postalCode = value;

        }

        public string Street
        {
            get => street;
            set => street = value;
        }
        public string Country
        {
            get => country;
            set => country = value;
        }

        public int DepartmentId
        {
            get => departmentId;
            set => departmentId = value;
        }

        public DateTime JoiningDate
        {
            get => joiningDate;
            set => joiningDate = value;
        }

        

        public string Designation
        {
            get => designation;
            set => designation = value;
        }

        
    }
}
