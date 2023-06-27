using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;
namespace DataAccessLayer.FakeDAL
{
    public class FakePaymentDAL : IPaymentDAL
    {
        private List<Payment> paymentList;

        public FakePaymentDAL()
        {
            paymentList = new List<Payment>();
        }

        public bool AddPayment(Payment payment)
        {
            paymentList.Add(payment);
            return true;
        }

        public DataTable GetAllPaymentInfo()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PaymentStatus", typeof(string));
            table.Columns.Add("PaymentType", typeof(string));
            table.Columns.Add("PaymentAmount", typeof(decimal));
            table.Columns.Add("BookingId", typeof(int));

            foreach (Payment payment in paymentList)
            {
                table.Rows.Add(payment.PaymentStatus, payment.PaymentType, payment.PaymentAmount, payment.BookingId);
            }

            return table;
        }
    }
}
