using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferClasses.Classes
{
    public class Payment
    {
        private int paymentId;
        private string paymentStatus;
        private string paymentType;
        private double paymentAmount;
        private int bookingId;


        


        public string PaymentStatus
        {
            get => paymentStatus;
            set => paymentStatus = value;
        }

        public string PaymentType
        {
            get => paymentType;
            set => paymentType = value;
        }

        public double PaymentAmount
        {
            get => paymentAmount;
            set => paymentAmount = value;
        }

        public int BookingId
        {
            get => bookingId;
            set => bookingId = value;
        }
    }
}
