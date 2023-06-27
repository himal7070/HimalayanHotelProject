using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;
using BusinessLogicLayer.InterfacesDAL;

namespace PresentationLayer.Views
{
    public partial class Login : Form
    {
        private IUserBLL userBLL; //interface for UserBLL
        private User user;

        public Login(IUserBLL userBLL) //IUserBLL instance through constructor
        {
            InitializeComponent();
            this.userBLL = userBLL; //assigning the injected instance
            user = new User();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;

            try
            {
                string isNewUser = userBLL.CheckNewUser(user);

                if (String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text))
                {
                    lblErrorMessage.Text = "All fields are required.";
                    lblErrorMessage.Visible = true;
                }
                else if (isNewUser.Equals("Yes"))
                {
                    Statics.SetUsername(tbUsername.Text);
                    Statics.SetPassword(tbPassword.Text);

                    IUserDAL userDAL = new UserDAL();
                    IUserBLL userBLL = new UserBLL(userDAL);
                    RegisterNewPassword register = new RegisterNewPassword(userBLL);
                    register.Show();
                    this.Hide();
                }
                else if (isNewUser.Equals("NO"))
                {
                    userBLL.Login(user);
                    //UserBLL.Instance.GetEmployeeIdToken(user);
                    Statics.SetEmployeeId(userBLL.GetEmployeeIdToken(user));         
                    Homepage db = new Homepage();
                    db.Show();
                    this.Hide();
                }
                else
                {
                    lblErrorMessage.Text = " Incorrect username or password";
                    lblErrorMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
