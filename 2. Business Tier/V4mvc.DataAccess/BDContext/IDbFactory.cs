using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace V4mvc.DataAccess
{
    public interface IDbFactory: IDisposable
    {
        SqlConnection EstablishedConnection(bool multipleActiveResultSets = false);
        Task<SqlConnection> EstablishedConnectionAsync();
    }
}
