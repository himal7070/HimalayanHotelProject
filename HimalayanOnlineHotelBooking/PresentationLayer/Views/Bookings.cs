using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;

namespace PresentationLayer.Views
{
    public partial class Bookings : Form
    {

        private IBookingBLL bookingBLL;
        private IGuestBLL guestBLL;
        private IRoomBookedBLL roomBookedBLL;
        private IRoomBLL roomBLL;
        private IRoomTypeBLL roomTypeBLL;

        private DiscountBLL discountBLL;

        public Bookings(
            User user,
            IBookingBLL bookingBLL,
            IGuestBLL guestBLL,
            IRoomBookedBLL roomBookedBLL,
            IRoomBLL roomBLL,
            IRoomTypeBLL roomTypeBLL)
        {
            InitializeComponent();

            this.bookingBLL = bookingBLL;
            this.guestBLL = guestBLL;
            this.roomBookedBLL = roomBookedBLL;
            this.roomBLL = roomBLL;
            this.roomTypeBLL = roomTypeBLL;
            this.discountBLL = new DiscountBLL(new DiscountDAL());
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            DisplayAllBookings(dgvBooking);
            DisplayDiscount();

            PopulateGuestComboBox();
            PopulateRoomTypeComboBox();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbGuestId.Text))
            {
                MessageBox.Show("Please select a guest Id.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cbRoomType.Text))
            {
                MessageBox.Show("Please select room type");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbTotalCost.Text))
            {
                MessageBox.Show("Please press calculate cost button to get total cost");
                return;
            }

            Booking bookingObj = FillEntity();
            try
            {
                bool success = bookingBLL.AddBooking(bookingObj);
                if (success)
                {
                    MessageBox.Show("Booking added successfully!", "Message", MessageBoxButtons.OK);

                    int recentId = bookingBLL.GetRecentBookingId();
                    guestBLL.UpdateGuestReserStatus(cbGuestId.Text);
                    roomBLL.UpdateRoomStatusNo(Convert.ToInt32(tbRoomId.Text));
                    roomBookedBLL.InsertRoomBooking(recentId, Convert.ToInt32(tbRoomId.Text));
                    btnClear_Click(sender, e);
                    PopulateGuestComboBox();
                    DisplayAllBookings(dgvBooking);

                }
                else
                {
                    MessageBox.Show("Booking failed!", "Message", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the booking: " + ex.Message, "Error", MessageBoxButtons.OK);
            }



        }


        private Booking FillEntity()
        {

            var booking = new Booking();


            booking.BookingDate = DateTime.Now;
            booking.StayDuration = Convert.ToInt32(lblStayDuration.Text);
            booking.CheckInDate = Convert.ToDateTime(dateTimeCheckIn.Text);
            booking.CheckOutDate = Convert.ToDateTime(dateTimeCheckOut.Text);
            booking.BookingAmount = Convert.ToDouble(tbTotalCost.Text);
            booking.EmployeeId = Statics.employeeIdToken;
            booking.GuestId = Convert.ToInt32(cbGuestId.Text);

            return booking;
        }


        private void PopulateGuestComboBox()
        {
            cbGuestId.Items.Clear();
            foreach (int guestId in guestBLL.GetAvailableGuestIds())
            {
                cbGuestId.Items.Add(guestId);
            }
        }



        private void DisplayAllBookings(DataGridView data)
        {
            try
            {
                data.DataSource = bookingBLL.GetAllBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBookingId.Clear();
            cbGuestId.Items.Clear();

            dateTimeCheckIn.ResetText();
            dateTimeCheckOut.ResetText();

            cbRoomType.Items.Clear();
            tbRoomId.Clear();

            lblStayDuration.Text = "";
            tbTotalCost.Clear();


            cbDiscountName.Items.Clear();

        }


        private void PopulateRoomTypeComboBox()
        {

            List<string> roomTypes = roomTypeBLL.GetRoomTypesForHotel();
            foreach (string roomType in roomTypes)
            {
                cbRoomType.Items.Add(roomType);
            }
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cbroomId = roomTypeBLL.GetRoomIdByName(cbRoomType.Text);
            tbRoomId.Text = cbroomId.ToString();

        }


        private int CalculateDuration()
        {
            DateTime checkInDate = dateTimeCheckIn.Value;
            DateTime checkOutDate = dateTimeCheckOut.Value;

            int durationInDays = (int)(checkOutDate - checkInDate).TotalDays;
            lblStayDuration.Text = durationInDays.ToString();

            return durationInDays;
        }



        private double GetTotalAmount(int duration)
        {
            double totalAmount = 0;

            try
            {
                double getDateDifference = duration + 1;
                double cost = roomTypeBLL.GetCost(cbRoomType.Text);
                double bonus = bookingBLL.CalculateDiscountPercentage(Convert.ToInt32(cbGuestId.Text));
                double rate = discountBLL.GetDiscountRate(cbDiscountName.Text);

                if (bonus != 0 && rate != 0)
                {
                    bonus = bonus / 100;
                    rate = rate / 100;
                    double totalDiscountPercentage = bonus + rate;
                    double discountedAmount = getDateDifference * cost * totalDiscountPercentage;
                    totalAmount = getDateDifference * cost - discountedAmount;

                    string message = "Congratulations! You received the following discounts:\n";
                    message += "- " + (bonus * 100) + "% discount for being our regular customer\n";
                    message += "- " + (rate * 100) + "% extra discount for using available hotel exclusive promotion\n";
                    message += "Total Discount: " + (totalDiscountPercentage * 100) + "%\n";
                    MessageBox.Show(message);

                }
                else if (bonus != 0)
                {
                    bonus = bonus / 100;
                    double discountedAmount = getDateDifference * cost * bonus;
                    totalAmount = getDateDifference * cost - discountedAmount;

                    MessageBox.Show("Congratulations! You got a " + bonus * 100 + "% discount for being our regular customer");
                }
                else if (rate != 0)
                {
                    double discountedAmount = getDateDifference * cost * (rate / 100);
                    totalAmount = getDateDifference * cost - discountedAmount;

                    string message = "Congratulations! You got a " + (rate / 100) * 100 + "% discount";
                    MessageBox.Show(message);

                }
                else
                {
                    totalAmount = getDateDifference * cost;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return totalAmount;
        }


        private bool ValidateDates()
        {
            DateTime checkInDate = dateTimeCheckIn.Value;
            DateTime checkOutDate = dateTimeCheckOut.Value;
            DateTime currentDate = DateTime.Today;

            if (checkOutDate <= checkInDate)
            {
                MessageBox.Show("Invalid date selection. Check-out date must be greater than the check-in date.");
                return false;
            }

            if (checkInDate.Date < currentDate.Date)
            {
                MessageBox.Show("Invalid check-in date. Check-in date must be the current date or a future date.");
                return false;
            }

            return true;
        }

        private void btnCalculateTotalCost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbGuestId.Text))
            {
                MessageBox.Show("Please select a guest Id.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cbRoomType.Text))
            {
                MessageBox.Show("Please select room type");
                return;
            }



            bool isValidDate = ValidateDates();

            if (isValidDate)
            {
                int duration = CalculateDuration();
                tbTotalCost.Text = GetTotalAmount(duration).ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbGuestId.Text))
            {
                MessageBox.Show("Please select a guest Id.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cbRoomType.Text))
            {
                MessageBox.Show("Please select room type");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbTotalCost.Text))
            {
                MessageBox.Show("Please press calculate cost button to get total cost");
                return;
            }

            Booking bookingObj = this.FillEntity();
            try
            {
                bool success = bookingBLL.UpdateBooking(bookingObj, Convert.ToInt32(tbBookingId.Text));
                if (success)
                {
                    MessageBox.Show("Booking updated successfully!", "Message", MessageBoxButtons.OK);
                    DisplayAllBookings(dgvBooking);
                }
                else
                {
                    MessageBox.Show("Booking updating failed!", "Message", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the booking: " + ex.Message, "Error", MessageBoxButtons.OK);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool success = bookingBLL.DeleteBooking(Convert.ToInt32(tbBookingId.Text));
                    if (success)
                    {
                        MessageBox.Show("Booking deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Booking deleting Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK);
                }

            }

            DisplayAllBookings(dgvBooking);
        }


        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBookingId.Text = dgvBooking.CurrentRow.Cells[0].Value.ToString();
            lblStayDuration.Text = dgvBooking.CurrentRow.Cells[2].Value.ToString();

            dateTimeCheckIn.Text = dgvBooking.CurrentRow.Cells[3].Value.ToString();
            dateTimeCheckOut.Text = dgvBooking.CurrentRow.Cells[4].Value.ToString();

            tbTotalCost.Text = dgvBooking.CurrentRow.Cells[5].Value.ToString();

            cbGuestId.Text = dgvBooking.CurrentRow.Cells[7].Value.ToString();

        }

        private void cbDiscountName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void DisplayDiscount()
        {
            List<string> discountNames = discountBLL.GetDiscountNames();
            cbDiscountName.Items.AddRange(discountNames.ToArray());

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.Hide();

            IRoomBLL roomBLL = new RoomBLL(new RoomDAL());
            FindGuestBookingInfo findGuestBookingInfo = new FindGuestBookingInfo(roomBLL);
            findGuestBookingInfo.ShowDialog();

            this.Show();
        }





    }
}
