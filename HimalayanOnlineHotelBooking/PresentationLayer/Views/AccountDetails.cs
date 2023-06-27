using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class AccountDetails : Form
    {
        private IUserBLL userBLL;
        private User newUser;

        public AccountDetails(IUserBLL userBLL)
        {
            InitializeComponent();
            this.userBLL = userBLL;
            newUser = new User();
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {

            newUser.Username = Statics.employeeNameAndId;
            newUser.Username = newUser.Username.Replace(" ", String.Empty);
            newUser.Password = userBLL.GenerateRandomPassword();
            tbUsername.Text = newUser.Username;
            tbPassword.Text = newUser.Password;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            newUser.Username = tbUsername.Text;
            newUser.Password = tbPassword.Text;

            try
            {
                bool success = userBLL.AddNewUser(newUser, Statics.tempEmployeeId);
                if (success)
                {
                    
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK);
            }          

            this.Hide();

        }
    }
}
