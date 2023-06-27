using DataTransferClasses.Classes;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer.InterfacesDAL;


namespace DataAccessLayer.DAL
{
    public class RoomDAL : IRoomDAL
    {

        ConnectionString cs = new ConnectionString();


        public bool AddRoom(Room room)
        {

            try
            {
                string query = "INSERT INTO [Rooms].[Room] VALUES(@RoomNumber, @RoomTypeId, @Available)";

                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                        cmd.Parameters.AddWithValue("@RoomTypeId", room.TypeId);
                        cmd.Parameters.AddWithValue("@Available", room.Status);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool UpdateRoom(Room room, int roomId)
        {
            try
            {
                string query = "UPDATE [Rooms].[Room] SET RoomTypeId = @RoomTypeId, Available = @Available, RoomNumber = @RoomNumber WHERE RoomId = @RoomId";

                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RoomTypeId", room.TypeId);
                        cmd.Parameters.AddWithValue("@Available", room.Status);
                        cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                        cmd.Parameters.AddWithValue("@RoomId", roomId);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool UpdateRoomStatusNo(int roomId)
        {
            try
            {
                string query = "UPDATE [Rooms].[Room] SET Available = 'No' WHERE RoomId = @RoomId";

                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RoomId", roomId);

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

        public bool UpdateRoomStatusYes(int roomId)
        {
            try
            {
                string query = "UPDATE [Rooms].[Room] SET Available = 'Yes' WHERE RoomId = @RoomId";

                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RoomId", roomId);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {
             
                throw;
            }
        }


        public List<string> GetRoomTypeName()
        {
            List<string> roomTypeList = new List<string>();

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();

                    string query = "SELECT Name FROM [Rooms].[RoomType]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string roomTypeName = reader.GetString(0);
                                roomTypeList.Add(roomTypeName);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {           
                throw;
            }

            return roomTypeList;

        }


        public DataTable GetAllRooms()
        {
            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM [Rooms].[Room]";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }




        public bool DeleteRoom(int roomId)
        {
            try
            {
                string query = "DELETE FROM [Rooms].[Room] WHERE RoomId = @RoomId";

                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RoomId", roomId);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }



        public List<Tuple<string, string, string, int, DateTime, DateTime, double>> GetRoomsByBookingId(int bookingId)
        {
            List<Tuple<string, string, string,  int, DateTime, DateTime, double>> roomList = new List<Tuple<string, string, string, int, DateTime, DateTime, double>>();

            string query = @"SELECT R.RoomNumber, RT.Name AS RoomTypeName, RT.Description, B.BookingDate, B.StayDuration, B.CheckInDate, B.CheckOutDate, B.BookingAmount
                            FROM Rooms.Room AS R
                            INNER JOIN Rooms.RoomBooked AS RB ON RB.RoomId = R.RoomId
                            INNER JOIN Rooms.RoomType AS RT ON R.RoomTypeId = RT.RoomTypeId
                            INNER JOIN Bookings.Booking AS B ON RB.BookingId = B.BookingId
                            WHERE RB.BookingId = @BookingId AND B.Status = 'Checkin'";

            using (SqlConnection connection = cs.getConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@BookingId", bookingId);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string roomNumber = reader["RoomNumber"].ToString();
                                string roomTypeName = reader["RoomTypeName"].ToString();
                                string description = reader["Description"].ToString();
                                int stayDuration = (int)reader["StayDuration"];
                                DateTime checkInDate = (DateTime)reader["CheckInDate"];
                                DateTime checkOutDate = (DateTime)reader["CheckOutDate"];
                                double bookingAmount = (double)reader["BookingAmount"];

                                var roomTuple = new Tuple<string, string, string, int, DateTime, DateTime, double>(
                                    roomNumber, roomTypeName, description, stayDuration, checkInDate, checkOutDate, bookingAmount);
                                roomList.Add(roomTuple);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return roomList;
        }



    }
}
