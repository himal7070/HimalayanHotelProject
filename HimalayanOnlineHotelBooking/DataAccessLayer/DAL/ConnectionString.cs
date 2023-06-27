using System.Data.SqlClient;
using BusinessLogicLayer.InterfacesDAL;

namespace DataAccessLayer.DAL
{
    public class ConnectionString : IConnectionString
    {

        //public SqlConnection getConnection()
        //{
        //    string connectionString = @"Data Source=DESKTOP-MC5L8BB\SQLEXPRESS;Initial Catalog=dbi356260_i356260fh;Integrated Security=True";
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    return connection;
        //}


        public SqlConnection getConnection()
        {
            string connectionString = @"data source = mssqlstud.fhict.local; persist security info = true; user id = dbi356260_i356260fh; password = 12345";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
}
