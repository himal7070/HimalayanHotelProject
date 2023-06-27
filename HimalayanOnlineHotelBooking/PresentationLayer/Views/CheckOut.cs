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
    public partial class CheckOut : Form
    {
        private IPaymentBLL paymentBLL;
        private IBookingBLL bookingBLL;
        private IGuestBLL guestBLL;
        private IRoomBLL roomBLL;
        private IRoomBookedBLL roomBookedBLL;

        public CheckOut(
            IPaymentBLL paymentBLL,
            IBookingBLL bookingBLL,
            IGuestBLL guestBLL,
            IRoomBLL roomBLL,
            IRoomBookedBLL roomBookedBLL)
        {
            InitializeComponent();
            this.paymentBLL = paymentBLL;
            this.bookingBLL = bookingBLL;
            this.guestBLL = guestBLL;
            this.roomBLL = roomBLL;
            this.roomBookedBLL = roomBookedBLL;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (cbBookingId.SelectedIndex != -1 && cbPaymentType.SelectedIndex != -1 && tbTotalAmount.Text != "")
            {
                int bookingId = int.Parse(cbBookingId.Text);
                int guestId = bookingBLL.GetGuestId(bookingId);
                guestBLL.UpdateGuestStatus(guestId);
                int roomId = roomBookedBLL.GetRoomId(bookingId);
                roomBLL.UpdateRoomStatusYes(roomId);

                Payment payment = FillEntity();
                string message = "Checkout Data inserted successfully!";
                paymentBLL.AddPayment(payment);
                MessageBox.Show(message);

                bookingBLL.ChangeBookingStatus(bookingId);

                PopulateBookingIdComboBox();
                GetAllPaymentInfo(dgvPayment);

            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }


        private void PopulateBookingIdComboBox()
        {
            try
            {
                List<string> bookingIds = bookingBLL.GetCheckinBookingIds();
                cbBookingId.DataSource = bookingIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         

        }

        private Payment FillEntity()
        {

            var payment = new Payment();


            payment.PaymentStatus = tbStatus.Text;
            payment.PaymentType = cbPaymentType.Text;
            payment.PaymentAmount = Convert.ToDouble(tbTotalAmount.Text);
            payment.BookingId = Convert.ToInt32(cbBookingId.Text);


            return payment;
        }



        private void CheckOut_Load(object sender, EventArgs e)
        {

            GetAllPaymentInfo(dgvPayment);
            PopulateBookingIdComboBox();


        }


        private void GetAllPaymentInfo(DataGridView data)
        {
            try
            {
                data.DataSource = paymentBLL.GetAllPaymentInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPaymentId.Clear();
            cbBookingId.Text = "";
            cbPaymentType.Text = "";
            tbTotalAmount.Clear();
        }

        private void cbBookingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bookingId = int.Parse(cbBookingId.SelectedValue.ToString());
            double bookingAmount = bookingBLL.GetBookingAmountById(bookingId);
            tbTotalAmount.Text = bookingAmount.ToString();

        }
    }
}
