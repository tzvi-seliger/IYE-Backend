using EmployeeAppBack.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeAppBack
{
    public class QueryReturn
    {
        private readonly string connectionString;

        public QueryReturn(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<TrainingFile> Execute(IDBQueryReturn query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                return query.Execute(conn);
            }
        }
    }
}