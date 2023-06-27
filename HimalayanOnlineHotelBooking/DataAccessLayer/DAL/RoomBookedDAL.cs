using System.Data.SqlClient;
using BusinessLogicLayer.InterfacesDAL;

namespace DataAccessLayer.DAL
{
    public class RoomBookedDAL : IRoomBookedDAL
    {
        ConnectionString cs = new ConnectionString();


        public void InsertRoomBooked(int bookingId, int roomId )
        {
            try
            {
                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    string query = "INSERT INTO [Rooms].[RoomBooked] (BookingId, RoomId) VALUES (@BookingId, @RoomId)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        cmd.Parameters.AddWithValue("@roomId", roomId);
                    

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }



        public int GetRoomId(int bookingId)
        {
            using (SqlConnection con = cs.getConnection())
            {
                try
                {
                    con.Open();

                    string query = "SELECT RoomId FROM [Rooms].[RoomBooked] WHERE BookingId = @BookingId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@BookingId", bookingId);

                    SqlDataReader dr = cmd.ExecuteReader();
                    int id = 0;

                    if (dr.Read())
                    {
                        id = dr.GetInt32(0);
                    }

                    return id;
                }
                catch (SqlException)
                {                   
                    return 0;
                }
            }
        }


     

    }
}
