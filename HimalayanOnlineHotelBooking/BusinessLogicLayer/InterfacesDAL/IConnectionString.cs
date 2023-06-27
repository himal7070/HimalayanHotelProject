using System.Data.SqlClient;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IConnectionString
    {
        SqlConnection getConnection();

    }
}
