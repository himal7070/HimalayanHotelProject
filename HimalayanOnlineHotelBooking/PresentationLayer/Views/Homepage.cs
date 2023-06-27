using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;
using BusinessLogicLayer.InterfacesDAL;

namespace PresentationLayer.Views
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            IUserDAL userDAL = new UserDAL(); 
            IUserBLL userBLL = new UserBLL(userDAL);
            Login login = new Login(userBLL);

            login.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();

            IEmployeeDAL employeeDAL = new EmployeeDAL();
            IDepartmentDAL departmentDAL = new DepartmentDAL();

            IEmployeeBLL employeeBLL = new EmployeeBLL(employeeDAL);
            IDepartmentBLL departmentBLL = new DepartmentBLL(departmentDAL);

    
            Employees employees = new Employees(departmentBLL, employeeBLL);
            employees.ShowDialog();

            this.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();

            IRoomTypeBLL roomTypeBLL = new RoomTypeBLL(new RoomTypeDAL());
            IRoomBLL roomBLL = new RoomBLL(new RoomDAL());

            Rooms room = new Rooms(roomTypeBLL, roomBLL);
            room.ShowDialog();

            this.Show();
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            this.Hide();

            IGuestBLL guestBLL = new GuestBLL(new GuestDAL());
            Guests guest = new Guests(guestBLL);
            guest.ShowDialog();

            this.Show();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();

            IBookingBLL bookingBLL = new BookingBLL(new BookingDAL());
            IGuestBLL guestBLL = new GuestBLL(new GuestDAL());
            IRoomBookedBLL roomBookedBLL = new RoomBookedBLL(new RoomBookedDAL());
            IRoomBLL roomBLL = new RoomBLL(new RoomDAL());
            IRoomTypeBLL roomTypeBLL = new RoomTypeBLL(new RoomTypeDAL());

         
            Bookings bookings = new Bookings(user, bookingBLL, guestBLL, roomBookedBLL, roomBLL, roomTypeBLL);
            bookings.ShowDialog();

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            IPaymentBLL paymentBLL = new PaymentBLL(new PaymentDAL());
            IBookingBLL bookingBLL = new BookingBLL(new BookingDAL());
            IGuestBLL guestBLL = new GuestBLL(new GuestDAL());
            IRoomBLL roomBLL = new RoomBLL(new RoomDAL());
            IRoomBookedBLL roomBookedBLL = new RoomBookedBLL(new RoomBookedDAL());

     
            CheckOut checkOut = new CheckOut(paymentBLL, bookingBLL, guestBLL, roomBLL, roomBookedBLL);
            checkOut.ShowDialog();

            this.Show();

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            this.Hide();

            Discounts discount = new Discounts();
            discount.ShowDialog();

            this.Show();
        }
    }
}
