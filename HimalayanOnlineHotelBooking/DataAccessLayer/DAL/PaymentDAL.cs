using DataTransferClasses.Classes;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer.InterfacesDAL;
namespace DataAccessLayer.DAL
{
    public class PaymentDAL : IPaymentDAL
    {
        ConnectionString cs = new ConnectionString();

        public bool AddPayment(Payment payment)
        {
            try
            {
                string query = "INSERT INTO [Bookings].[Payment] VALUES (@PaymentStatus, @PaymentType, @PaymentAmount, @BookingId)";

                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PaymentStatus", payment.PaymentStatus);
                        cmd.Parameters.AddWithValue("@PaymentType", payment.PaymentType);
                        cmd.Parameters.AddWithValue("@PaymentAmount", payment.PaymentAmount);
                        cmd.Parameters.AddWithValue("@BookingId", payment.BookingId);

                        cmd.ExecuteNonQuery();
                    }
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public DataTable GetAllPaymentInfo()
        {
            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Bookings].[Payment]", connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
                catch (Exception)
                {                 
                    throw;
                }
            }

        }


       




    }
}
