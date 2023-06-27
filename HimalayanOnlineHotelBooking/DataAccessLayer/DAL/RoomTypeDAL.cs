using DataTransferClasses.Classes;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer.InterfacesDAL;

namespace DataAccessLayer.DAL
{
    public class RoomTypeDAL : IRoomTypeDAL
    {
       
        ConnectionString cs = new ConnectionString();

        public bool AddRoomType(RoomType roomType)
        {

            string query = "INSERT INTO [Rooms].[RoomType] (Name, Cost, Description) VALUES (@Name, @Cost, @Description)";

            using (SqlConnection con = cs.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", roomType.Name);
                cmd.Parameters.AddWithValue("@Cost", roomType.Cost);
                cmd.Parameters.AddWithValue("@Description", roomType.Description);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return true;

        }


        public DataTable GetAllRoomTypes()
        {
            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from [Rooms].[RoomType]", connection);
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

        public bool UpdateRoomType(RoomType roomType,int roomTypeID)
         {
            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "UPDATE [Rooms].[RoomType] SET Name = @Name, Cost = @Cost, Description = @Description WHERE RoomTypeId = @RoomTypeId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", roomType.Name);
                    command.Parameters.AddWithValue("@Cost", roomType.Cost);
                    command.Parameters.AddWithValue("@Description", roomType.Description);
                    command.Parameters.AddWithValue("@RoomTypeId", roomTypeID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }


        public bool DeleteRoomType(string roomTypeId)
        {
            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "DELETE FROM [Rooms].[RoomType] WHERE RoomTypeId = @RoomTypeId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomTypeId", roomTypeId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public int GetRoomTypeIdByName(string name)
        {
            int roomTypeId = 0;

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "SELECT RoomTypeId FROM [Rooms].[RoomType] WHERE Name = @Name";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            roomTypeId = reader.GetInt32(0);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return roomTypeId;
        }

        public int GetRoomIdByName(string name)
        {
            int roomId = 0;

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "SELECT r.RoomId FROM [Rooms].[Room] AS r JOIN [Rooms].[RoomType] AS rt ON r.RoomTypeId = rt.RoomTypeId WHERE rt.Name = @Name AND r.Available = 'Yes'";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            roomId = reader.GetInt32(0);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return roomId;
        }




        public List<string> GetDistinctRoomTypesForHotel()
        {
            List<string> roomTypes = new List<string>();

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "SELECT DISTINCT(Name) FROM [Rooms].[RoomType] AS rt JOIN [Rooms].[Room] AS r ON r.RoomTypeId = rt.RoomTypeId WHERE Available = 'Yes'";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roomTypes.Add(reader["Name"].ToString());
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return roomTypes;

        }


        public double GetCost(string name)
        {
            double cost = 0;

            try
            {
                using (SqlConnection con = cs.getConnection())
                using (SqlCommand cmd = new SqlCommand("SELECT rt.Cost FROM [Rooms].[Room] AS r JOIN [Rooms].[RoomType] AS rt ON r.RoomTypeId = rt.RoomTypeId WHERE rt.Name = @Name AND Available = 'Yes'", con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            cost = dr.GetDouble(0);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return cost;
        }



    }


    
}
