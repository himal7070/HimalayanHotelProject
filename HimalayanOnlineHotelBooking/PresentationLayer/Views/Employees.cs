using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;
using System.Text.RegularExpressions;

namespace PresentationLayer.Views
{
    public partial class Employees : Form
    {
        private IDepartmentBLL departmentBLL;
        private IEmployeeBLL employeeBLL;


        public Employees(IDepartmentBLL departmentBLL, IEmployeeBLL employeeBLL)
        {
            InitializeComponent();
            this.departmentBLL = departmentBLL;
            this.employeeBLL = employeeBLL;

        }



        private void btnAddDepartments_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDepartmentName.Text))
            {
                MessageBox.Show("Please enter department name");
                return;
            }
            if (!Regex.IsMatch(tbDepartmentName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid department name. Only alphabetic characters and spaces are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbDepartmentDesc.Text))
            {
                MessageBox.Show("Please enter department description");
                return;
            }

            if (!Regex.IsMatch(tbDepartmentDesc.Text, @"^[A-Za-z0-9\s\p{P},]+$"))
            {
                MessageBox.Show("Invalid department description. Only alphanumeric characters, spaces, punctuation marks, and commas are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbSalary.Text))
            {
                MessageBox.Show("Please enter salary amount");
                return;
            }

            if (!float.TryParse(tbSalary.Text, out _))
            {
                MessageBox.Show("Invalid salary value", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!Regex.IsMatch(tbSalary.Text, @"^\d+(\.\d{1,2})?$"))
            {
                MessageBox.Show("Invalid salary value. Please enter a valid numeric amount.", "Error", MessageBoxButtons.OK);
                return;
            }


            Department departmentObj = this.FillEntityDepartment();
            try
            {
                bool success = departmentBLL.AddDepartment(departmentObj);
                if (success)
                {
                    MessageBox.Show("Department added successfully!");
                }
                else
                {
                    MessageBox.Show("Department adding failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

            btnClearDepartments_Click(null, null);
            DisplayAllDepartment(dgvDepartment);
        }


        private Department FillEntityDepartment()
        {

            var department = new Department();



            department.DepartmentName = tbDepartmentName.Text;
            department.DepartmentDescription = tbDepartmentDesc.Text;
            department.Salary = float.Parse(tbSalary.Text);

            return department;
        }



        private void btnUpdateDepartments_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDepartmentName.Text))
            {
                MessageBox.Show("Please enter department name");
                return;
            }
            if (!Regex.IsMatch(tbDepartmentName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid department name. Only alphabetic characters and spaces are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbDepartmentDesc.Text))
            {
                MessageBox.Show("Please enter department description");
                return;
            }

            if (!Regex.IsMatch(tbDepartmentDesc.Text, @"^[A-Za-z0-9\s\p{P},]+$"))
            {
                MessageBox.Show("Invalid department description. Only alphanumeric characters, spaces, punctuation marks, and commas are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbSalary.Text))
            {
                MessageBox.Show("Please enter salary amount");
                return;
            }

            if (!float.TryParse(tbSalary.Text, out _))
            {
                MessageBox.Show("Invalid salary value", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!Regex.IsMatch(tbSalary.Text, @"^\d+(\.\d{1,2})?$"))
            {
                MessageBox.Show("Invalid salary value. Please enter a valid numeric amount.", "Error", MessageBoxButtons.OK);
                return;
            }


            Department departmentObj = this.FillEntityDepartment();

            try
            {
                bool success = departmentBLL.UpdateDepartment(departmentObj, Convert.ToInt32(tbDepartmentId.Text));
                if (success)
                {
                    MessageBox.Show("Department updated successfully!", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Department updating Failed!", "Message", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

            btnClearDepartments_Click(null, null);
            DisplayAllDepartment(dgvDepartment);

        }


        private void btnDeleteDepartments_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool success = departmentBLL.DeleteDepartment(Convert.ToInt32(tbDepartmentId.Text));
                    if (success)
                    {
                        MessageBox.Show("Department deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Department deleting Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

            }
            DisplayAllDepartment(dgvDepartment);
        }


        private void DisplayAllDepartment(DataGridView data)
        {
            try
            {
                data.DataSource = departmentBLL.GetAllDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClearDepartments_Click(object sender, EventArgs e)
        {
            tbDepartmentId.Clear();
            tbDepartmentName.Clear();
            tbDepartmentDesc.Clear();
            tbSalary.Clear();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

            List<string> departmentNames = departmentBLL.GetDepartmentName(); ////

            foreach (string departmentName in departmentNames)
            {
                cbDepartments.Items.Add(departmentName);
            }

            DisplayAllDepartment(dgvDepartment);
            DisplayAllEmployees(dgvEmployees);


        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbDepartmentId.Text = dgvDepartment.CurrentRow.Cells[0].Value.ToString();
            tbDepartmentName.Text = dgvDepartment.CurrentRow.Cells[1].Value.ToString();
            tbDepartmentDesc.Text = dgvDepartment.CurrentRow.Cells[2].Value.ToString();
            tbSalary.Text = dgvDepartment.CurrentRow.Cells[3].Value.ToString();
        }


        //--------------------------------------------------------------------------------------------EmployeePart--------------------------------------------------------------------------------


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                MessageBox.Show("Please enter first name");
                return;
            }

            if (!Regex.IsMatch(tbFirstName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid first name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                MessageBox.Show("Please enter last name");
                return;
            }

            if (!Regex.IsMatch(tbLastName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid last name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Please enter email");
                return;
            }

            if (!Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Please enter phone number");
                return;
            }

            if (!Regex.IsMatch(tbPhone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Invalid phone number. Phone number should be a 10-digit number.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!IsNumeric(tbPhone.Text))
            {
                MessageBox.Show("Invalid phone number. Please enter a numeric value.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbCity.Text))
            {
                MessageBox.Show("Please enter city");
                return;
            }

            if (!Regex.IsMatch(tbCity.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid city name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPostalCode.Text))
            {
                MessageBox.Show("Please enter postal code");
                return;
            }

            if (!Regex.IsMatch(tbPostalCode.Text, @"^\d{4}[A-Za-z]{2}$"))
            {
                MessageBox.Show("Invalid postal code. Postal code should be in the format '5616VC'.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbStreet.Text))
            {
                MessageBox.Show("Please enter street");
                return;
            }

            if (!Regex.IsMatch(tbStreet.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Invalid street name. Only alphanumeric characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbCountry.Text))
            {
                MessageBox.Show("Please enter country");
                return;
            }

            if (!Regex.IsMatch(tbCountry.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid country name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbDepartments.Text))
            {
                MessageBox.Show("Please select department");
                return;
            }
            if (string.IsNullOrWhiteSpace(cbDesignation.Text))
            {
                MessageBox.Show("Please select designation");
                return;
            }



            if (cbDesignation.Text == "Manager")
            {
                Employee employeeObj = this.FillEntity();
                try
                {
                    bool success = employeeBLL.AddEmployees(employeeObj);
                    if (success)
                    {
                        MessageBox.Show("You are required to create account in order to register!");
                        Statics.SetTempEmplId(Statics.maxId);
                        Statics.EmployeeNameId(Statics.maxId, tbFirstName.Text);


                        IUserBLL userBLL = new UserBLL(new UserDAL());
                        AccountDetails screen = new AccountDetails(userBLL);
                        screen.ShowDialog();

                        DisplayAllEmployees(dgvEmployees);
                    }
                    else
                    {
                        MessageBox.Show("Employee adding Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                Employee employeeObj = this.FillEntity();
                try
                {
                    bool success = employeeBLL.AddEmployees(employeeObj);
                    if (success)
                    {
                        MessageBox.Show("Employee has been added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Employee adding Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }



                DisplayAllEmployees(dgvEmployees);
            }


        }
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private Employee FillEntity()
        {

            var employee = new Employee();


            employee.FirstName = this.tbFirstName.Text;
            employee.LastName = this.tbLastName.Text;
            employee.Email = this.tbEmail.Text;
            employee.Phone = this.tbPhone.Text;
            employee.City = this.tbCity.Text;
            employee.PostalCode = this.tbPostalCode.Text;
            employee.Street = this.tbStreet.Text;
            employee.Country = this.tbCountry.Text;
            employee.DepartmentId = departmentBLL.GetDepartmentId(cbDepartments.Text);
            employee.Designation = this.cbDesignation.Text;
            employee.JoiningDate = Convert.ToDateTime(this.dtpJoiningDate.Text);




            return employee;
        }




        private void DisplayAllEmployees(DataGridView data)
        {
            try
            {
                data.DataSource = employeeBLL.GetAllEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            tbEmployeeId.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmail.Clear();
            tbPhone.Clear();
            tbCity.Clear();
            tbPostalCode.Clear();
            tbStreet.Clear();
            tbCountry.Clear();
            cbDepartments.Text = string.Empty;
            cbDesignation.Text = string.Empty;

            dtpJoiningDate.Text = string.Empty;
        }


        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                MessageBox.Show("Please enter first name");
                return;
            }

            if (!Regex.IsMatch(tbFirstName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid first name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                MessageBox.Show("Please enter last name");
                return;
            }

            if (!Regex.IsMatch(tbLastName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid last name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Please enter email");
                return;
            }

            if (!Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Please enter phone number");
                return;
            }

            if (!Regex.IsMatch(tbPhone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Invalid phone number. Phone number should be a 10-digit number.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!IsNumeric(tbPhone.Text))
            {
                MessageBox.Show("Invalid phone number. Please enter a numeric value.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbCity.Text))
            {
                MessageBox.Show("Please enter city");
                return;
            }

            if (!Regex.IsMatch(tbCity.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid city name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPostalCode.Text))
            {
                MessageBox.Show("Please enter postal code");
                return;
            }

            if (!Regex.IsMatch(tbPostalCode.Text, @"^\d{4}[A-Za-z]{2}$"))
            {
                MessageBox.Show("Invalid postal code. Postal code should be in the format '5616VC'.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbStreet.Text))
            {
                MessageBox.Show("Please enter street");
                return;
            }

            if (!Regex.IsMatch(tbStreet.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Invalid street name. Only alphanumeric characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbCountry.Text))
            {
                MessageBox.Show("Please enter country");
                return;
            }

            if (!Regex.IsMatch(tbCountry.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid country name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbDepartments.Text))
            {
                MessageBox.Show("Please select department");
                return;
            }
            if (string.IsNullOrWhiteSpace(cbDesignation.Text))
            {
                MessageBox.Show("Please select designation");
                return;
            }



            Employee employeeObj = this.FillEntity();
            try
            {
                bool success = employeeBLL.UpdateEmployee(employeeObj, Convert.ToInt32(tbEmployeeId.Text));
                if (success)
                {
                    MessageBox.Show("Employee info updated successfully!");
                }
                else
                {
                    MessageBox.Show("Employee info updating Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

            DisplayAllEmployees(dgvEmployees);
        }



        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool success = employeeBLL.DeleteEmployee(tbEmployeeId.Text);
                    if (success)
                    {
                        MessageBox.Show("Employee record deleted successfully");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }


            }

            DisplayAllEmployees(dgvEmployees);




        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvEmployees.Rows[e.RowIndex];

                tbEmployeeId.Text = selectedRow.Cells["PersonId"].Value.ToString();
                tbFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                tbLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                tbEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                tbPhone.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                tbCity.Text = selectedRow.Cells["City"].Value.ToString();
                tbStreet.Text = selectedRow.Cells["Street"].Value.ToString();
                tbPostalCode.Text = selectedRow.Cells["PostalCode"].Value.ToString();
                tbCountry.Text = selectedRow.Cells["Country"].Value.ToString();
                cbDepartments.Text = selectedRow.Cells["DepartmentId"].Value.ToString();
                cbDesignation.Text = selectedRow.Cells["Designation"].Value.ToString();
                dtpJoiningDate.Value = Convert.ToDateTime(selectedRow.Cells["JoiningDate"].Value);

            }



            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = dgvEmployees.Rows[e.RowIndex];

            //    tbEmployeeId.Text = selectedRow.Cells[0].Value.ToString();
            //    tbFirstName.Text = selectedRow.Cells[1].Value.ToString();
            //    tbLastName.Text = selectedRow.Cells[2].Value.ToString();
            //    tbEmail.Text = selectedRow.Cells[3].Value.ToString();
            //    tbPhone.Text = selectedRow.Cells[4].Value.ToString();
            //    tbCity.Text = selectedRow.Cells[5].Value.ToString();
            //    tbPostalCode.Text = selectedRow.Cells[6].Value.ToString();
            //    tbStreet.Text = selectedRow.Cells[7].Value.ToString();
            //    tbCountry.Text = selectedRow.Cells[8].Value.ToString();

            //    cbDepartments.Text = selectedRow.Cells[9].Value.ToString();
            //    cbDesignation.Text = selectedRow.Cells[10].Value.ToString();
            //    dtpJoiningDate.Text = selectedRow.Cells[11].Value.ToString();

            //}
        }


    }
}
