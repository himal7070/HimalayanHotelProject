using DataTransferClasses.Classes;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer.InterfacesDAL;


namespace DataAccessLayer.DAL
{
    public class UserDAL : IUserDAL
    {
        ConnectionString cs = new ConnectionString();

        private static Random _random = new Random();

        public bool Login(User user)
        {
            bool isAuthenticated = false;

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "SELECT COUNT(*) FROM [Authentication].[Login] WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);

                    connection.Open();

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    isAuthenticated = count > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isAuthenticated;
        }



        public string CheckNewUser(User user)
        {
            string newUser = string.Empty;

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    string query = "SELECT NewUser FROM [Authentication].[Login] WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            newUser = reader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return newUser;

        }


        public string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }



        public bool AddNewUser(User user, int tempEmployeeId)
        {
            try
            {
                string query = "INSERT INTO [Authentication].[Login] (Username, Password, EmployeeId) VALUES (@Username, @Password, @EmployeeId)";

                using (SqlConnection connection = cs.getConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@EmployeeId", tempEmployeeId);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }


        public bool UpdatePassword(User user)
        {

            try
            {
                string query = "UPDATE [Authentication].[Login] SET Username = @NewUsername, Password = @NewPassword, NewUser = 'NO' WHERE Username = @Username";

                using (SqlConnection connection = cs.getConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewUsername", user.Username);
                        command.Parameters.AddWithValue("@NewPassword", user.Password);
                        command.Parameters.AddWithValue("@Username", user.Username);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
             
                throw;
            }

            return false;

            
        }


        public int GetEmployeeIdToken(User user)
        {
            int employeeIdToken = 0;

            using (SqlConnection con = cs.getConnection())
            {
                string query = "SELECT EmployeeId FROM [Authentication].[Login] WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                try
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if (!dr.IsDBNull(0))
                        {
                            employeeIdToken = dr.GetInt32(0);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return employeeIdToken;

        }

        public int GetGuestIdToken(User user)
        {
            int guestIdToken = 0;

            using (SqlConnection con = cs.getConnection())
            {
                string query = "SELECT GuestId FROM [Authentication].[Login] WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                try
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if (!dr.IsDBNull(0))
                        {
                            guestIdToken = dr.GetInt32(0);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return guestIdToken;

        }

        public bool InsertGuestAndLoginData(Guest guest, User user)
        {
            string selectUserQuery = "SELECT COUNT(*) FROM Authentication.Login WHERE Username = @Username";
            string selectPersonQuery = "SELECT COUNT(*) FROM Hotel.Person WHERE Email = @Email";
            string insertPersonQuery = "INSERT INTO Hotel.Person (PersonType, FirstName, LastName, Email, PhoneNumber, City, Street, PostalCode, Country) VALUES ('Guest', @FirstName, @LastName, @Email, @PhoneNumber, @City, @Street, @PostalCode, @Country); SELECT SCOPE_IDENTITY();";
            string insertGuestQuery = "INSERT INTO Hotel.Guest (PersonId, PassportNumber, Status) VALUES (@PersonId, @PassportNumber , 'Not Reserved')";
            string insertLoginQuery = "INSERT INTO Authentication.Login (Username, Password, EmployeeId, GuestId, NewUser) VALUES (@Username, @Password, NULL, (SELECT MAX(PersonId) FROM Hotel.Person), 'NO')";

            try
            {
                using (SqlConnection connection = cs.getConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;

                        // Check if username already exists
                        command.CommandText = selectUserQuery;
                        command.Parameters.AddWithValue("@Username", user.Username);
                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            throw new Exception("Username already exists.");
                        }

                        // Check if email address already exists in the Person table
                        command.CommandText = selectPersonQuery;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Email", guest.Email);
                        int personCount = Convert.ToInt32(command.ExecuteScalar());

                        if (personCount > 0)
                        {
                            throw new Exception("Email address already exists.");
                        }

                        // Insert into Person table
                        command.CommandText = insertPersonQuery;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@FirstName", guest.FirstName);
                        command.Parameters.AddWithValue("@LastName", guest.LastName);
                        command.Parameters.AddWithValue("@Email", guest.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", guest.Phone);
                        command.Parameters.AddWithValue("@City", guest.City);
                        command.Parameters.AddWithValue("@Street", guest.Street);
                        command.Parameters.AddWithValue("@PostalCode", guest.PostalCode);
                        command.Parameters.AddWithValue("@Country", guest.Country);

                        // Execute the query and retrieve the PersonId
                        int personId = Convert.ToInt32(command.ExecuteScalar());

                        // Insert into Guest table
                        command.CommandText = insertGuestQuery;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PersonId", personId);
                        command.Parameters.AddWithValue("@PassportNumber", guest.PassportNumber);
                        command.ExecuteNonQuery();

                        // Insert into Login table
                        command.CommandText = insertLoginQuery;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }








            //string selectUserQuery = "SELECT COUNT(*) FROM [Authentication].[Login] WHERE Username = @Username";
            //string selectPersonQuery = "SELECT COUNT(*) FROM [Hotel].[Person] WHERE Email = @Email";
            //string selectGuestQuery = "SELECT COUNT(*) FROM [Hotel].[Guest] WHERE GuestId = @GuestId";

            //string insertPersonQuery = "INSERT INTO [Hotel].[Person] (FirstName, LastName, Email, PhoneNumber, City, Street, PostalCode, Country) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @City, @Street, @PostalCode, @Country); SELECT SCOPE_IDENTITY();";
            //string insertGuestQuery = "INSERT INTO [Hotel].[Guest] (PersonId, PassportNumber, Status) VALUES (@PersonId, @PassportNumber, 'Not Reserved');";
            //string insertLoginQuery = "INSERT INTO [Authentication].[Login] (Username, Password, EmployeeId, GuestId, NewUser) VALUES (@Username, @Password, NULL, (SELECT MAX(GuestId) FROM [Hotel].[Guest]), 'NO')";

            //try
            //{
            //    using (SqlConnection connection = cs.getConnection())
            //    {
            //        connection.Open();

            //        using (SqlCommand command = new SqlCommand())
            //        {
            //            command.Connection = connection;

            //            // Check if username already exists
            //            command.CommandText = selectUserQuery;
            //            command.Parameters.AddWithValue("@Username", user.Username);
            //            int userCount = Convert.ToInt32(command.ExecuteScalar());

            //            if (userCount > 0)
            //            {
            //                throw new Exception("Username already exists.");
            //            }

            //            // Check if email address already exists in the Person table
            //            command.CommandText = selectPersonQuery;
            //            command.Parameters.Clear();
            //            command.Parameters.AddWithValue("@Email", guest.Email);
            //            int personCount = Convert.ToInt32(command.ExecuteScalar());

            //            if (personCount > 0)
            //            {
            //                throw new Exception("Email address already exists.");
            //            }

            //            // Check if guestId already exists in the Guest table
            //            command.CommandText = selectGuestQuery;
            //            command.Parameters.Clear();
            //            command.Parameters.AddWithValue("@GuestId", guest.GuestId);
            //            int guestCount = Convert.ToInt32(command.ExecuteScalar());

            //            if (guestCount > 0)
            //            {
            //                throw new Exception("Guest ID already exists.");
            //            }

            //            // Insert into Person table
            //            command.CommandText = insertPersonQuery;
            //            command.Parameters.Clear();
            //            command.Parameters.AddWithValue("@FirstName", guest.FirstName);
            //            command.Parameters.AddWithValue("@LastName", guest.LastName);
            //            command.Parameters.AddWithValue("@Email", guest.Email);
            //            command.Parameters.AddWithValue("@PhoneNumber", guest.Phone);
            //            command.Parameters.AddWithValue("@City", guest.City);
            //            command.Parameters.AddWithValue("@Street", guest.Street);
            //            command.Parameters.AddWithValue("@PostalCode", guest.PostalCode);
            //            command.Parameters.AddWithValue("@Country", guest.Country);

            //            // Execute the query and retrieve the PersonId
            //            int personId = Convert.ToInt32(command.ExecuteScalar());

            //            // Insert into Guest table
            //            command.CommandText = insertGuestQuery;
            //            command.Parameters.Clear();
            //            command.Parameters.AddWithValue("@PersonId", personId);
            //            command.Parameters.AddWithValue("@PassportNumber", guest.PassportNumber);
            //            command.ExecuteNonQuery();

            //            // Insert into Login table
            //            command.CommandText = insertLoginQuery;
            //            command.Parameters.Clear();
            //            command.Parameters.AddWithValue("@Username", user.Username);
            //            command.Parameters.AddWithValue("@Password", user.Password);
            //            command.ExecuteNonQuery();
            //        }

            //        connection.Close();
            //    }

            //    return true;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}







        }

    }





    
}
