using EmployeeAppBack.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeAppBack.Queries
{
    public class GetTrainingFilesByTraining : IDBQueryReturn
    {
        private readonly int _trainingId;
        private readonly List<TrainingFile> trainingFiles = new List<TrainingFile>();

        public GetTrainingFilesByTraining(int trainingId)
        {
            _trainingId = trainingId;
        }

        public List<TrainingFile> Execute(SqlConnection conn)
        {
            SqlCommand Add = new SqlCommand(BuildQuery(out List<SqlParameter> parameters), conn);
            Add.Parameters.AddRange(parameters.ToArray());
            SqlDataReader reader = Add.ExecuteReader();
            while (reader.Read())
            {
                trainingFiles.Add(new TrainingFile
                {
                    TrainingFileID = Convert.ToInt32(reader["TrainingFileID"]),
                    TrainingFileDescription= Convert.ToString(reader["TrainingFileDescription"]),
                    TrainingFileOrderNo = Convert.ToInt32(reader["TrainingFileOrderNo"]),
                    TrainingFilePath = Convert.ToString(reader["TrainingFilePath"])
                });
            }
            return trainingFiles;
        }

        public string BuildQuery(out List<SqlParameter> parameters)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter
            {
                ParameterName = "@TrainingId",
                Value = _trainingId,
                SqlDbType = SqlDbType.Int
            });

            return "select * from TrainingFiles where TrainingId = @TrainingId ";
        }
    }
}