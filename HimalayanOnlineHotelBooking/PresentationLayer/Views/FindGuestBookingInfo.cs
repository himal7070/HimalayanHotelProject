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
    public partial class FindGuestBookingInfo : Form
    {
        private IRoomBLL roomBLL;


        public FindGuestBookingInfo(IRoomBLL roomBLL)
        {
            InitializeComponent();
            this.roomBLL = roomBLL;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingId = int.Parse(tbBookingId.Text);

                List<Tuple<string, string, string, int, DateTime, DateTime, double>> roomList = roomBLL.GetRoomsByBookingId(bookingId);

                string roomInformation = "";
                foreach (var roomTuple in roomList)
                {
                    string roomNumber = roomTuple.Item1;
                    string roomTypeName = roomTuple.Item2;
                    string description = roomTuple.Item3;
                    int stayDuration = roomTuple.Item4;
                    DateTime checkInDate = roomTuple.Item5;
                    DateTime checkOutDate = roomTuple.Item6;
                    double bookingAmount = roomTuple.Item7;

                    roomInformation += $"Room Number: {roomNumber}\n";
                    roomInformation += $"Room Type: {roomTypeName}\n";
                    roomInformation += $"Stay Duration: {stayDuration}\n";
                    roomInformation += $"Check-In Date: {checkInDate}\n";
                    roomInformation += $"Check-Out Date: {checkOutDate}\n";
                    roomInformation += $"Booking Amount: {bookingAmount}\n\n";


                    int charCount = 0;
                    string row = "Description :";

                    foreach (char c in description)
                    {
                        row += c;
                        charCount++;

                        if (charCount >= 100)
                        {
                            roomInformation += row + "\n";
                            row = "";
                            charCount = 0;
                        }
                    }

                    if (!string.IsNullOrEmpty(row))
                        roomInformation += row + "\n";

                    roomInformation += "\n";
                }

                lblBookingInfo.Text = roomInformation;
            }
            catch (Exception ex)
            {
                lblBookingInfo.Text = "Error retrieving room information: " + ex.Message;
            }



          
        }




    }


}

