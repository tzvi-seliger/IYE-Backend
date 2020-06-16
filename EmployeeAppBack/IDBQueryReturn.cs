using EmployeeAppBack.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeAppBack
{
    public interface IDBQueryReturn
    {
        List<TrainingFile> Execute (SqlConnection conn);

    }
}