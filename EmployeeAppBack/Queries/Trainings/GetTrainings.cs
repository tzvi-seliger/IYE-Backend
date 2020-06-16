using EmployeeAppBack.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeAppBack.Queries
{
    public class GetTrainings
    {
        private readonly string connectionString;

        public GetTrainings(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Training> Execute()
        {
            List<Training> trainings = new List<Training>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand SelectAll = new SqlCommand(BuildQuery(), conn);
                SqlDataReader reader = SelectAll.ExecuteReader();
                while (reader.Read())
                {
                    trainings.Add(new Training
                    {
                        AccountID = Convert.ToInt32(reader["AccountID"]),
                        TrainingDescription = Convert.ToString(reader["TrainingDescription"]),
                        TrainingID = Convert.ToInt32(reader["TrainingID"]),
                        TrainingName = Convert.ToString(reader["TrainingName"]),
                    });
                }
            }
            return trainings;
        }

        public string BuildQuery()
        {
            return "SELECT * FROM trainings";
        }
    }
}