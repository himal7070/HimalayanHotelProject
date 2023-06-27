using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;

namespace PresentationLayer.Views
{
    public partial class RegisterNewPassword : Form
    {

        User user;
        private IUserBLL userBLL;

        public RegisterNewPassword(IUserBLL userBLL)
        {
            InitializeComponent();
            user = new User();
            this.userBLL = userBLL;
        }


        private void RegisterNewPassword_Load(object sender, EventArgs e)
        {


        }


        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Please enter your username");
                return;
            }

            if (String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter your password");
                return;
            }
            if (String.IsNullOrWhiteSpace(tbNewPassword.Text))
            {
                MessageBox.Show("Please enter new password");
                return;
            }
            if (String.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                MessageBox.Show("Please enter your new password again");
                return;
            }

            if (tbNewPassword.Text.Length < 5 || tbConfirmPassword.Text.Length < 5)
            {
                MessageBox.Show("Minimum password length must be 8.", "Incorrect Info", MessageBoxButtons.OK);
                return;
            }

            if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Incorrect Info", MessageBoxButtons.OK);
                return;
            }

            user.Username = tbUsername.Text;
            user.Password = tbNewPassword.Text;

            try
            {
                bool success = userBLL.UpdatePassword(user);
                if (success)
                {
                    MessageBox.Show("Your new password has been set");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
          
            

            this.Hide();
            Homepage homepage = new Homepage();
            homepage.ShowDialog();
            this.Show();

          
        }
    }
}
