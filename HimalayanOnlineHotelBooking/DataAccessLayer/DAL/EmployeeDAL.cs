using DataTransferClasses.Classes;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer.InterfacesDAL;


namespace DataAccessLayer.DAL
{
    public class EmployeeDAL : IEmployeeDAL
    {

        ConnectionString cs = new ConnectionString();
        
        public bool AddEmployees(Employee employee, out string errorMessage)
        {

            try
            {
                string query = "INSERT INTO [Hotel].[Person] (PersonType, FirstName, LastName, Email, PhoneNumber, City, PostalCode, Street, Country) " +
                               "VALUES ('Employee', @FirstName, @LastName, @Email, @Phone, @City, @PostalCode, @Street, @Country); " +
                               "DECLARE @PersonId INT = SCOPE_IDENTITY(); " +
                               "INSERT INTO [Hotel].[Employee] (PersonId, DepartmentId, Designation, JoiningDate) " +
                               "VALUES (@PersonId, @DepartmentId, @Designation, @JoiningDate)";

                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                        cmd.Parameters.AddWithValue("@Email", employee.Email);
                        cmd.Parameters.AddWithValue("@Phone", employee.Phone);
                        cmd.Parameters.AddWithValue("@City", employee.City);
                        cmd.Parameters.AddWithValue("@PostalCode", employee.PostalCode);
                        cmd.Parameters.AddWithValue("@Street", employee.Street);
                        cmd.Parameters.AddWithValue("@Country", employee.Country);
                        cmd.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
                        cmd.Parameters.AddWithValue("@Designation", employee.Designation);
                        cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);

                        cmd.ExecuteNonQuery();
                    }

                    query = "SELECT MAX(E.PersonId) " +
                            "FROM [Hotel].[Employee] E " +
                            "INNER JOIN [Hotel].[Person] P ON E.PersonId = P.PersonId " +
                            "WHERE P.FirstName = @FirstName AND P.LastName = @LastName";

                    using (SqlCommand cmd1 = new SqlCommand(query, con))
                    {
                        cmd1.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        cmd1.Parameters.AddWithValue("@LastName", employee.LastName);

                        using (SqlDataReader dr = cmd1.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                Statics.maxId = dr.GetInt32(0);
                            }
                        }
                    }
                }

                errorMessage = null;
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                throw;
            }




            //try
            //{
            //    string query = "INSERT INTO [Hotel].[Person] (FirstName, LastName, Email, PhoneNumber, City, PostalCode, Street, Country) " +
            //                   "VALUES (@FirstName, @LastName, @Email, @Phone, @City, @PostalCode, @Street, @Country); " +
            //                   "DECLARE @PersonId INT = SCOPE_IDENTITY(); " +
            //                   "INSERT INTO [Hotel].[Employee] (PersonId, DepartmentId, Designation, JoiningDate) " +
            //                   "VALUES (@PersonId, @DepartmentId, @Designation, @JoiningDate)";

            //    using (SqlConnection con = cs.getConnection())
            //    {
            //        con.Open();

            //        using (SqlCommand cmd = new SqlCommand(query, con))
            //        {
            //            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            //            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            //            cmd.Parameters.AddWithValue("@Email", employee.Email);
            //            cmd.Parameters.AddWithValue("@Phone", employee.Phone);
            //            cmd.Parameters.AddWithValue("@City", employee.City);
            //            cmd.Parameters.AddWithValue("@PostalCode", employee.PostalCode);
            //            cmd.Parameters.AddWithValue("@Street", employee.Street);
            //            cmd.Parameters.AddWithValue("@Country", employee.Country);
            //            cmd.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
            //            cmd.Parameters.AddWithValue("@Designation", employee.Designation);
            //            cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);

            //            cmd.ExecuteNonQuery();
            //        }

            //        query = "SELECT MAX(E.EmployeeId) " +
            //                "FROM [Hotel].[Employee] E " +
            //                "INNER JOIN [Hotel].[Person] P ON E.PersonId = P.PersonId " +
            //                "WHERE P.FirstName = @FirstName AND P.LastName = @LastName";

            //        using (SqlCommand cmd1 = new SqlCommand(query, con))
            //        {
            //            cmd1.Parameters.AddWithValue("@FirstName", employee.FirstName);
            //            cmd1.Parameters.AddWithValue("@LastName", employee.LastName);

            //            using (SqlDataReader dr = cmd1.ExecuteReader())
            //            {
            //                if (dr.Read())
            //                {
            //                    Statics.maxId = dr.GetInt32(0);
            //                }
            //            }
            //        }
            //    }

            //    errorMessage = null;
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    errorMessage = ex.Message;
            //    throw;
            //}






        }

        public bool UpdateEmployee(Employee employee, int employeeId)
        {
            try
            {
                using (SqlConnection con = cs.getConnection())
                {
                    con.Open();

                    string query = "UPDATE [Hotel].[Person] " +
                                   "SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @Phone, " +
                                   "City = @City, PostalCode = @PostalCode, Street = @Street, Country = @Country " +
                                   "WHERE PersonId = (SELECT PersonId FROM [Hotel].[Employee] WHERE PersonId = @EmployeeId); " +
                                   "UPDATE [Hotel].[Employee] " +
                                   "SET Designation = @Designation, JoiningDate = @JoiningDate, DepartmentId = @DepartmentId " +
                                   "WHERE PersonId = @EmployeeId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                        cmd.Parameters.AddWithValue("@Email", employee.Email);
                        cmd.Parameters.AddWithValue("@Phone", employee.Phone);
                        cmd.Parameters.AddWithValue("@City", employee.City);
                        cmd.Parameters.AddWithValue("@PostalCode", employee.PostalCode);
                        cmd.Parameters.AddWithValue("@Street", employee.Street);
                        cmd.Parameters.AddWithValue("@Country", employee.Country);
                        cmd.Parameters.AddWithValue("@Designation", employee.Designation);
                        cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);
                        cmd.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
                        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

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

        public bool DeleteEmployee(string employeeId)
        {
        
            string query = "DELETE FROM [Hotel].[Employee] WHERE PersonId = @EmployeeId";

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }


       

        public DataTable GetAllEmployees()
        {
            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT E.*, P.FirstName, P.LastName, P.Email, P.PhoneNumber, P.City, P.Street, P.PostalCode, P.Country " +
                                   "FROM [Hotel].[Employee] E " +
                                   "INNER JOIN [Hotel].[Person] P ON E.PersonId = P.PersonId";

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

         

            //using (SqlConnection connection = cs.getConnection())
            //{
            //    try
            //    {
            //        connection.Open();
            //        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Hotel].[Employee]", connection);
            //        DataTable table = new DataTable();
            //        adapter.Fill(table);
            //        return table;
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //}

        }




      
    }
}
