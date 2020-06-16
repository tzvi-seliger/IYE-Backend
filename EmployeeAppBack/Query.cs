using System.Data.SqlClient;

namespace EmployeeAppBack
{
    public class Query
    {
        private readonly string connectionString;

        public Query(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Execute(IDBQuery query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                query.Execute(conn);
            }
        }
    }
}