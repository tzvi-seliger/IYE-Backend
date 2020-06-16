using EmployeeAppBack.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeAppBack.Queries
{
    public class AddTraining : IDBQuery
    {
        private readonly Training _training;

        public AddTraining(Training training)
        {
            this._training = training;
        }

        public void Execute(SqlConnection conn)
        {
            SqlCommand Add = new SqlCommand(BuildQuery(out List<SqlParameter> parameters), conn);
            Add.Parameters.AddRange(parameters.ToArray());
            Add.ExecuteNonQuery();
        }

        public string BuildQuery(out List<SqlParameter> parameters)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter
            {
                ParameterName = "@AccountId",
                Value = _training.AccountID,
                SqlDbType = SqlDbType.Int
            });
            parameters.Add(new SqlParameter
            {
                ParameterName = "@TrainingName",
                Value = _training.TrainingName,
                SqlDbType = SqlDbType.VarChar
            });
            parameters.Add(new SqlParameter
            {
                ParameterName = "@TrainingDescription",
                Value = _training.TrainingDescription,
                SqlDbType = SqlDbType.VarChar
            });

            return $"INSERT INTO Trainings (AccountId, TrainingName, TrainingDescription) " +
                $"VALUES (@AccountID, @TrainingName, @TrainingDescription);";
        }
    }
}