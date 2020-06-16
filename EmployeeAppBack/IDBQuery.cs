using System.Data.SqlClient;

namespace EmployeeAppBack
{
    public interface IDBQuery
    {
        void Execute(SqlConnection conn);

    }
}