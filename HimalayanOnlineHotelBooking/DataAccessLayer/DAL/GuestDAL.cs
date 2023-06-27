using DataTransferClasses.Classes;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer.InterfacesDAL;

namespace DataAccessLayer.DAL
{
    public class GuestDAL : IGuestDAL
    {
        ConnectionString cs = new ConnectionString();

    
        public bool AddGuest(Guest guest)
        {
            string query = "INSERT INTO [Hotel].[Person] (PersonType, FirstName, LastName, Email, PhoneNumber, City, PostalCode, Street, Country) " +
                 "VALUES ('Guest', @FirstName, @LastName, @Email, @Phone, @City, @PostalCode, @Street, @Country); " +
                 "DECLARE @PersonId INT = SCOPE_IDENTITY(); " +
                 "INSERT INTO [Hotel].[Guest] (PersonId, PassportNumber, Status) VALUES (@PersonId, @PassportNumber , 'Not Reserved');";

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", guest.FirstName);
                    command.Parameters.AddWithValue("@LastName", guest.LastName);
                    command.Parameters.AddWithValue("@Email", guest.Email);
                    command.Parameters.AddWithValue("@Phone", guest.Phone);
                    command.Parameters.AddWithValue("@City", guest.City);
                    command.Parameters.AddWithValue("@PostalCode", guest.PostalCode);
                    command.Parameters.AddWithValue("@Street", guest.Street);
                    command.Parameters.AddWithValue("@Country", guest.Country);
                    command.Parameters.AddWithValue("@PassportNumber", guest.PassportNumber);

                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }


        public bool UpdateGuest(Guest guest, string guestId)
        {
            string query = "UPDATE [Hotel].[Person] " +
                           "SET FirstName = @FirstName, LastName = @LastName, Email = @Email, " +
                           "PhoneNumber = @Phone, City = @City, PostalCode = @PostalCode, " +
                           "Street = @Street, Country = @Country " +
                           "WHERE PersonId = (SELECT PersonId FROM [Hotel].[Guest] WHERE PersonId = @GuestId);" +
                           "UPDATE [Hotel].[Guest] " +
                           "SET PassportNumber = @PassportNumber " +
                           "WHERE PersonId = @GuestId";

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", guest.FirstName);
                    command.Parameters.AddWithValue("@LastName", guest.LastName);
                    command.Parameters.AddWithValue("@Email", guest.Email);
                    command.Parameters.AddWithValue("@Phone", guest.Phone);
                    command.Parameters.AddWithValue("@City", guest.City);
                    command.Parameters.AddWithValue("@PostalCode", guest.PostalCode);
                    command.Parameters.AddWithValue("@Street", guest.Street);
                    command.Parameters.AddWithValue("@Country", guest.Country);
                    command.Parameters.AddWithValue("@PassportNumber", guest.PassportNumber);
                    command.Parameters.AddWithValue("@GuestId", guestId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

     

        public bool UpdateGuestReserStatus(string guestId)
        {
            string query = "UPDATE [Hotel].[Guest] SET Status = 'Reserved' WHERE PersonId = @GuestId";

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GuestId", guestId);

                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    throw;

                }
            }
        }

        public bool UpdateGuestStatus(int guestId)
        {
            string query = "UPDATE [Hotel].[Guest] SET Status = 'Not Reserved' WHERE PersonId = @GuestId";

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GuestId", guestId);

                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    throw;

                }
            }
        }

        public bool DeleteGuest(string strGuestId)
        {
            string deleteLoginQuery = "DELETE FROM [Authentication].[Login] WHERE GuestId = @GuestId";
            string deleteGuestQuery = "DELETE FROM [Hotel].[Guest] WHERE PersonId = @GuestId";
            string deletePersonQuery = "DELETE FROM [Hotel].[Person] WHERE PersonId = @GuestId";
            string deleteBookingsQuery = "DELETE FROM [Bookings].[Booking] WHERE GuestId = @GuestId";

            bool isCheckOut = IsGuestStatusCheckOut(strGuestId);

            if (!isCheckOut)
            {
                return false;
            }

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand deleteBookingsCommand = new SqlCommand(deleteBookingsQuery, connection);
                    deleteBookingsCommand.Parameters.AddWithValue("@GuestId", strGuestId);
                    deleteBookingsCommand.ExecuteNonQuery();

                    SqlCommand deleteLoginCommand = new SqlCommand(deleteLoginQuery, connection);
                    deleteLoginCommand.Parameters.AddWithValue("@GuestId", strGuestId);
                    deleteLoginCommand.ExecuteNonQuery();

                    SqlCommand deleteGuestCommand = new SqlCommand(deleteGuestQuery, connection);
                    deleteGuestCommand.Parameters.AddWithValue("@GuestId", strGuestId);
                    deleteGuestCommand.ExecuteNonQuery();

                    SqlCommand deletePersonCommand = new SqlCommand(deletePersonQuery, connection);
                    deletePersonCommand.Parameters.AddWithValue("@GuestId", strGuestId);
                    deletePersonCommand.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private bool IsGuestStatusCheckOut(string strGuestId)
        {
            string guestStatusQuery = "SELECT Status FROM [Bookings].[Booking] WHERE GuestId = @GuestId AND Status = 'Checkout'";
            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(guestStatusQuery, connection);
                    command.Parameters.AddWithValue("@GuestId", strGuestId);

                    object result = command.ExecuteScalar();

                    return result != null;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }




        public List<int> GetAvailableGuestIds()
        {
            List<int> availableGuestIds = new List<int>();

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT PersonId FROM [Hotel].[Guest] WHERE Status = 'Not Reserved'";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int guestId = (int)reader["PersonId"];
                            availableGuestIds.Add(guestId);
                        }
                    }

                    return availableGuestIds;
                }
                catch (Exception)
                {
                    throw;

                }
            }
        }


        public DataTable GetAllGuestsInfo()
        {

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT G.*, P.FirstName, P.LastName, P.Email, P.PhoneNumber, P.City, P.Street, P.PostalCode, P.Country " +
                                   "FROM [Hotel].[Guest] G " +
                                   "INNER JOIN [Hotel].[Person] P ON G.PersonId = P.PersonId";

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

        public Guest GetGuestDetails(int guestPersonId)
        {
            Guest guest = null;

            using (SqlConnection connection = cs.getConnection())
            {
                string query = "SELECT G.PassportNumber, P.FirstName, P.LastName, P.Email, P.PhoneNumber, P.City, P.PostalCode, P.Street, P.Country " +
                               "FROM Hotel.Guest G " +
                               "JOIN Hotel.Person P ON G.PersonId = P.PersonId " +
                               "WHERE G.PersonId = @GuestPersonId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestPersonId", guestPersonId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    guest = new Guest
                    {
                        PassportNumber = reader["PassportNumber"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["PhoneNumber"].ToString(),
                        City = reader["City"].ToString(),
                        PostalCode = reader["PostalCode"].ToString(),
                        Street = reader["Street"].ToString(),
                        Country = reader["Country"].ToString()
                    };
                }

                reader.Close();
            }

            return guest;
        }
    }
}

