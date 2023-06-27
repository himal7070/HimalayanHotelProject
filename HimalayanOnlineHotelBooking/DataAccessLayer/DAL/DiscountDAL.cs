using BusinessLogicLayer.InterfacesDAL;
using DataTransferClasses.Classes;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer.DAL
{
    public class DiscountDAL : IDiscountDAL
    {
        ConnectionString cs = new ConnectionString();

        public bool InsertDiscount(Discount discount)
        {
            string query = "INSERT INTO [Bookings].[Discount] (DiscountName, DiscountDescription, DiscountRate, StartDate, EndDate) VALUES (@Name, @Description, @Rate, @StartDate, @EndDate)";

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", discount.Name);
                        cmd.Parameters.AddWithValue("@Description", discount.Description);
                        cmd.Parameters.AddWithValue("@Rate", discount.Rate);
                        cmd.Parameters.AddWithValue("@StartDate", discount.StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", discount.EndDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public bool UpdateDiscount(Discount discount, string discountId)
        {
            string query = "UPDATE [Bookings].[Discount] SET DiscountName = @Name, DiscountDescription = @Description, DiscountRate = @Rate, StartDate = @StartDate, EndDate = @EndDate WHERE DiscountId = @DiscountId";

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", discount.Name);
                        cmd.Parameters.AddWithValue("@Description", discount.Description);
                        cmd.Parameters.AddWithValue("@Rate", discount.Rate);
                        cmd.Parameters.AddWithValue("@StartDate", discount.StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", discount.EndDate);
                   
                        cmd.Parameters.AddWithValue("@DiscountId", discountId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }


        public bool DeleteDiscount(int discountId)
        {
            string query = "DELETE FROM [Bookings].[Discount] WHERE DiscountId = @DiscountId";

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DiscountId", discountId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public DataTable GetAllDiscountInfo()
        {
            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM [Bookings].[Discount]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
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

        public List<string> GetDiscountNames()
        {

            List<string> discountNames = new List<string>();
            using (SqlConnection con = cs.getConnection())
            {
                con.Open();
                string query = "SELECT DiscountName FROM Bookings.Discount WHERE EndDate >= @CurrentDate";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now.Date);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string discountName = dr.GetString(0);
                    discountNames.Add(discountName);
                }
            }
            return discountNames;


          
        }


        public int GetDiscountRate(string discountName)
        {
            int rate = 0;
            using (SqlConnection con = cs.getConnection())
            {
                con.Open();
                string query = "SELECT DiscountRate AS DR FROM [Bookings].[Discount] WHERE DiscountName = @DiscountName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DiscountName", discountName);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    rate = dr.GetInt32(0);
                }
            }
            return rate;
        }


        //public double GetDiscountRate(string discountName)
        //{
        //    double rate = 0.0;
        //    using (SqlConnection con = cs.getConnection())
        //    {
        //        con.Open();
        //        string query = "SELECT DiscountRate AS DR FROM [Bookings].[Discount] WHERE DiscountName = @DiscountName";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@DiscountName", discountName);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            rate = dr.GetDouble(0);
        //        }
        //    }
        //    return rate;
        //}


    }
}
