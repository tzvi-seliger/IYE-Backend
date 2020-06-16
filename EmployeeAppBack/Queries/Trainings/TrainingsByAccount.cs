using EmployeeAppBack.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeAppBack.Queries
{
    public class TrainingsByAccount
    {
        private readonly string connectionString;

        public TrainingsByAccount(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Training> Execute(int id)
        {
            List<Training> trainings = new List<Training>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand SelectAll = new SqlCommand(BuildQuery(id), conn);
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

        public string BuildQuery(int id)
        {
            return $"SELECT * FROM trainings WHERE AccountId = {id}";
        }
    }
}