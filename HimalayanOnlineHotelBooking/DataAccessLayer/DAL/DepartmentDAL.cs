using DataTransferClasses.Classes;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer.InterfacesDAL;

namespace DataAccessLayer.DAL
{
    public class DepartmentDAL : IDepartmentDAL
    {

        ConnectionString cs = new ConnectionString();

        public bool AddDepartment(Department department)
        {
            string query = "INSERT INTO [Hotel].[Department] VALUES(@DepartmentName, @DepartmentDescription, @Salary)";

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                    command.Parameters.AddWithValue("@DepartmentDescription", department.DepartmentDescription);
                    command.Parameters.AddWithValue("@Salary", department.Salary);

                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        public bool UpdateDepartment(Department department, int departmentId)
        {
            string query = "UPDATE [Hotel].[Department] SET Name = @DepartmentName, Description = @DepartmentDescription, Salary = @Salary WHERE DepartmentId = @DepartmentId";

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                    command.Parameters.AddWithValue("@DepartmentDescription", department.DepartmentDescription);
                    command.Parameters.AddWithValue("@Salary", department.Salary);
                    command.Parameters.AddWithValue("@DepartmentId", departmentId);

                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        public bool DeleteDepartment(int departmentId)
        {
            string query = "DELETE FROM [Hotel].[Department] WHERE DepartmentId = @DepartmentId";

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DepartmentId", departmentId);

                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    

        public DataTable GetAllDepartments()
        {
            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM [Hotel].[Department]";
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


        public List<string> GetDepartmentName()
        {
            List<string> departmentList = new List<string>();

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Name FROM [Hotel].[Department]";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string departmentName = reader.GetString(0);
                            departmentList.Add(departmentName);
                        }
                    }

                    return departmentList;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }


        public int GetDepartmentId(string departmentName)
        {
            int departmentId = 0;

            using (SqlConnection connection = cs.getConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DepartmentId FROM [Hotel].[Department] WHERE Name = @Name";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", departmentName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            departmentId = reader.GetInt32(0);
                        }
                    }

                    return departmentId;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }



    }
}
