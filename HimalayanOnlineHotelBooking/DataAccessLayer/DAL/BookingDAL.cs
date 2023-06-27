using BusinessLogicLayer.InterfacesDAL;
using DataTransferClasses.Classes;
using System.Data;
using System.Data.SqlClient;



namespace DataAccessLayer.DAL
{
    public class BookingDAL : IBookingDAL
    {
        ConnectionString cs = new ConnectionString();

        public bool AddBooking(Booking booking)
        {
            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "INSERT INTO [Bookings].[Booking] (BookingDate, StayDuration, CheckInDate, CheckOutDate, BookingAmount, EmployeeId, GuestId, Status) VALUES (@BookingDate, @StayDuration, @CheckInDate, @CheckOutDate, @BookingAmount, @EmployeeId, @GuestId, 'Checkin')";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                    command.Parameters.AddWithValue("@StayDuration", booking.StayDuration);
                    command.Parameters.AddWithValue("@CheckInDate", booking.CheckInDate);
                    command.Parameters.AddWithValue("@CheckOutDate", booking.CheckOutDate);
                    command.Parameters.AddWithValue("@BookingAmount", booking.BookingAmount);
                    command.Parameters.AddWithValue("@EmployeeId", Statics.employeeIdToken);
                    command.Parameters.AddWithValue("@GuestId", booking.GuestId);

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

        public bool AddBookingByGuest(Booking booking)
        {
            using (SqlConnection con = cs.getConnection())
            {
                try
                {
                    con.Open();

                    string query = "INSERT INTO [Bookings].[Booking] (BookingDate, StayDuration, CheckInDate, CheckOutDate, BookingAmount, EmployeeId, GuestId, Status) VALUES (CONVERT(DATE, @BookingDate), @StayDuration, CONVERT(DATE, @CheckInDate), CONVERT(DATE, @CheckOutDate), @BookingAmount, NULL, @GuestId, 'Checkin')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BookingDate", booking.BookingDate.Date);
                        cmd.Parameters.AddWithValue("@StayDuration", booking.StayDuration);
                        cmd.Parameters.AddWithValue("@CheckInDate", booking.CheckInDate.Date);
                        cmd.Parameters.AddWithValue("@CheckOutDate", booking.CheckOutDate.Date);
                        cmd.Parameters.AddWithValue("@BookingAmount", booking.BookingAmount);
                        cmd.Parameters.AddWithValue("@GuestId", booking.GuestId);

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }


        public Booking GetBookingDetailsByGuestId(int guestId)
        {
            Booking booking = null;

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();

                    string query = "SELECT BookingId, BookingDate, CheckInDate, CheckOutDate, StayDuration FROM [Bookings].[Booking] WHERE GuestId = @GuestId AND Status = 'Checkin'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GuestId", guestId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                booking = new Booking
                                {
                                    BookingId = reader.GetInt32(0),
                                    BookingDate = reader.GetDateTime(1),
                                    CheckInDate = reader.GetDateTime(2),
                                    CheckOutDate = reader.GetDateTime(3),
                                    StayDuration = reader.GetInt32(4)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return booking;
        }


        public bool CheckBookingExists(int guestId)
        {
            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM [Bookings].[Booking] WHERE GuestId = @GuestId AND Status = 'Checkin'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GuestId", guestId);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateBooking(Booking booking, int bookingId)
        {
            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "UPDATE [Bookings].[Booking] SET CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate WHERE BookingId = @BookingId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CheckInDate", booking.CheckInDate);
                    command.Parameters.AddWithValue("@CheckOutDate", booking.CheckOutDate);
                    command.Parameters.AddWithValue("@BookingId", bookingId);

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



        public bool DeleteBooking(int bookingId)
        {
            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "DELETE FROM [Bookings].[Booking] WHERE BookingId = @BookingId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookingId", bookingId);

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


        public bool ChangeBookingStatus(int bookingId)
        {
            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "UPDATE [Bookings].[Booking] SET Status = 'Checkout' WHERE BookingId = @BookingId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookingId", bookingId);

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


        public int GetRecentBookingId()
        {
            int recentId = 0;

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "SELECT MAX(BookingId) FROM [Bookings].[Booking]";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        recentId = Convert.ToInt32(result);
                    }

                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return recentId;

        }



        public DataTable GetAllBookingInfo()
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Bookings].[Booking]", connection);
                    adapter.Fill(table);
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return table;
        }


        public List<int> GetAllBookingId()
        {
            List<int> bookingIds = new List<int>();

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();

                    string query = "SELECT BookingId FROM [Bookings].[Booking] WHERE Status = 'checkin'";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookingId = reader.GetInt32(0);
                            bookingIds.Add(bookingId);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return bookingIds;
        }


        public int GetGuestId(int bookingId)
        {
            int guestId = 0;

            try
            {
                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    string query = "SELECT GuestId FROM [Bookings].[Booking] WHERE BookingId = @bookingId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                if (!dr.IsDBNull(0))
                                {
                                    guestId = dr.GetInt32(0);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return guestId;
        }


        public List<string> GetCheckinBookingIds()
        {
            List<string> bookingIds = new List<string>();

            try
            {
                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    string query = "SELECT BookingId FROM [Bookings].[Booking] WHERE Status = 'Checkin'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string? bookingId = dr["BookingId"].ToString();
                                if (bookingId != null)
                                {
                                    bookingIds.Add(bookingId);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return bookingIds;
        }


        public double GetBookingAmountById(int bookingId)
        {
            double bookingAmount = 0;

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "SELECT BookingAmount FROM [Bookings].[Booking] WHERE BookingId = @BookingId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookingId", bookingId);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bookingAmount = reader.GetDouble(0);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return bookingAmount;
        }




        public List<Booking> GetGuestBookings(int guestId)
        {
            List<Booking> bookings = new List<Booking>();

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();

                    string query = "SELECT BookingId, GuestId, BookingDate FROM Bookings.Booking WHERE GuestId = @GuestId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GuestId", guestId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int bookingId = reader.GetInt32(0);
                                int bookingGuestId = reader.GetInt32(1);
                                DateTime bookingDate = reader.GetDateTime(2);

                                Booking booking = new Booking
                                {
                                    BookingId = bookingId,
                                    GuestId = bookingGuestId,
                                    BookingDate = bookingDate
                                };

                                bookings.Add(booking);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
               throw;
            }

            return bookings;
        }

    }
}
