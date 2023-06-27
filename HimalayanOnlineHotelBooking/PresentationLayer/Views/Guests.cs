using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using System.Text.RegularExpressions;

namespace PresentationLayer.Views
{
    public partial class Guests : Form
    {
        private IGuestBLL guestBLL; //interface for GuestBLL

        public Guests(IGuestBLL guestBLL) //accepting IGuestBLL instance through constructor
        {
            InitializeComponent();
            this.guestBLL = guestBLL; //assigning the injected instance
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                Guest guestObj = this.FillEntity();
                try
                {
                    bool success = guestBLL.AddGuest(guestObj);
                    if (success)
                    {
                        MessageBox.Show("Guest added Successfully!", "Message", MessageBoxButtons.OK);

                        DisplayAllGuests(dgvGuest);
                        btnClear_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Guest added Failed!", "Message", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

              

            }
        }
        private bool IsFormValid()
        {
            //if (string.IsNullOrEmpty(tbFirstName.Text) ||
            //    string.IsNullOrEmpty(tbLastName.Text) ||
            //    string.IsNullOrEmpty(tbEmail.Text) ||
            //    string.IsNullOrEmpty(tbPhone.Text) ||
            //    string.IsNullOrEmpty(tbPassportNumber.Text) ||
            //    string.IsNullOrEmpty(tbCity.Text) ||
            //    string.IsNullOrEmpty(tbStreet.Text) ||
            //    string.IsNullOrEmpty(tbPostalCode.Text) ||
            //    string.IsNullOrEmpty(tbCountry.Text))
            //{
            //    MessageBox.Show("Please provide all information", "Error", MessageBoxButtons.OK);
            //    return false;
            //}
            //if (!Regex.IsMatch(tbFirstName.Text, @"^[A-Za-z\s]+$"))
            //{
            //    MessageBox.Show("Invalid first name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
            //    return false;
            //}

            //if (!Regex.IsMatch(tbLastName.Text, @"^[A-Za-z\s]+$"))
            //{
            //    MessageBox.Show("Invalid last name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
            //    return false;
            //}

            //if (!Regex.IsMatch(tbPhone.Text, @"^\d{10}$"))
            //{
            //    MessageBox.Show("Invalid phone number. Phone number should be a 10-digit number.", "Error", MessageBoxButtons.OK);
            //    return false;
            //}

            //if (!Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            //{
            //    MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK);
            //    return false;
            //}

            //if (!Regex.IsMatch(tbPassportNumber.Text, @"^[A-Za-z0-9]+$"))
            //{
            //    MessageBox.Show("Invalid passport number. Only alphanumeric characters are allowed.", "Error", MessageBoxButtons.OK);
            //    return false;
            //}

            //if (!Regex.IsMatch(tbCity.Text, @"^[A-Za-z\s]+$"))
            //{
            //    MessageBox.Show("Invalid city name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
            //    return false;
            //}

            //if (!Regex.IsMatch(tbStreet.Text, @"^[A-Za-z0-9\s]+$"))
            //{
            //    MessageBox.Show("Invalid street name. Only alphanumeric characters are allowed.", "Error", MessageBoxButtons.OK);
            //    return false;
            //}

            //if (!Regex.IsMatch(tbPostalCode.Text, @"^\d{4}[A-Za-z]{2}$"))
            //{
            //    MessageBox.Show("Invalid postal code. Postal code should be in the format '5616VC'.", "Error", MessageBoxButtons.OK);
            //    return false;
            //}

            //if (!Regex.IsMatch(tbCountry.Text, @"^[A-Za-z\s]+$"))
            //{
            //    MessageBox.Show("Invalid country name. Only alphabetic characters are allowed.", "Error", MessageBoxButtons.OK);
            //    return false;
            //}

            return true;
        }

        private Guest FillEntity()
        {

            var guest = new Guest();


            guest.FirstName = this.tbFirstName.Text;
            guest.LastName = this.tbLastName.Text;
            guest.Email = this.tbEmail.Text;
            guest.Phone = this.tbPhone.Text;
            guest.PassportNumber = this.tbPhone.Text;
            guest.Street = this.tbStreet.Text;
            guest.City = this.tbCity.Text;
            guest.PostalCode = this.tbPostalCode.Text;
            guest.Country = this.tbCountry.Text;


            return guest;
        }




        private void DisplayAllGuests(DataGridView data)
        {
            try
            {
                data.DataSource = guestBLL.GetAllGuestInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

    

        private void Guests_Load(object sender, EventArgs e)
        {
            DisplayAllGuests(dgvGuest);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbGuestId.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmail.Clear();
            tbPhone.Clear();
            tbPassportNumber.Clear();
            tbCity.Clear();
            tbStreet.Clear();
            tbPostalCode.Clear();
            tbCountry.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                Guest guestObj = this.FillEntity();

                try
                {
                    bool success = guestBLL.UpdateGuest(guestObj, tbGuestId.Text);
                    if (success)
                    {
                        MessageBox.Show("Guest updated Successfully!", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Guest updating Failed!", "Message", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

                DisplayAllGuests(dgvGuest);
                btnClear_Click(null, null);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool deletionResult = guestBLL.DeleteGuest(tbGuestId.Text);
                    if (deletionResult)
                    {
                        MessageBox.Show("Guest deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete guest. There are associated bookings or the deletion failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

            DisplayAllGuests(dgvGuest);
            btnClear_Click(null, null);

        }

        private void dgvGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is clicked
            {
                DataGridViewRow row = dgvGuest.Rows[e.RowIndex];

                tbGuestId.Text = row.Cells["PersonId"].Value.ToString();
                tbFirstName.Text = row.Cells["FirstName"].Value.ToString();
                tbLastName.Text = row.Cells["LastName"].Value.ToString();
                tbEmail.Text = row.Cells["Email"].Value.ToString();
                tbPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                tbPassportNumber.Text = row.Cells["PassportNumber"].Value.ToString();
                tbCity.Text = row.Cells["City"].Value.ToString();
                tbStreet.Text = row.Cells["Street"].Value.ToString();
                tbPostalCode.Text = row.Cells["PostalCode"].Value.ToString();
                tbCountry.Text = row.Cells["Country"].Value.ToString();
            }


            //tbGuestId.Text = dgvGuest.CurrentRow.Cells["GuestId"].Value.ToString();
            //tbFirstName.Text = dgvGuest.CurrentRow.Cells["FirstName"].Value.ToString();
            //tbLastName.Text = dgvGuest.CurrentRow.Cells["LastName"].Value.ToString();
            //tbEmail.Text = dgvGuest.CurrentRow.Cells["Email"].Value.ToString();
            //tbPhone.Text = dgvGuest.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            //tbPassportNumber.Text = dgvGuest.CurrentRow.Cells["PassportNumber"].Value.ToString();
            //tbCity.Text = dgvGuest.CurrentRow.Cells["City"].Value.ToString();
            //tbStreet.Text = dgvGuest.CurrentRow.Cells["Street"].Value.ToString();
            //tbPostalCode.Text = dgvGuest.CurrentRow.Cells["PostalCode"].Value.ToString();
            //tbCountry.Text = dgvGuest.CurrentRow.Cells["Country"].Value.ToString();


        }
    }
}
