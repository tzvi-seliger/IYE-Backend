
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAppBack.Models;


namespace EmployeeAppBack.DAL
{
    public class DALUser
    {
        private readonly string connectionString;

        public DALUser(string connectionString)
        {
            this.connectionString = connectionString;
        }


        // TODO api/user/id
        public User GetUser(string uname, string password)
        {
            User user = GetUsers().FirstOrDefault(x => x.UserName == uname);
            if (user.PasswordString == password)
            {
                return user;
            }
            return new User
            {
                AccountID = 0
            };
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM Users", conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        users.Add(
                            new User
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                AccountID = Convert.ToInt32(reader["AccountID"]),
                                UserFirstName = Convert.ToString(reader["UserFirstName"]),
                                UserName = Convert.ToString(reader["UserName"]),
                                UserEmailAddress = Convert.ToString(reader["UserEmailAddress"]),
                                UserPhoneNumber = Convert.ToString(reader["UserPhoneNumber"]),
                                UserType = Convert.ToString(reader["UserType"]),
                                UserLastName = Convert.ToString(reader["UserLastName"]),
                                PasswordString = Convert.ToString(reader["PasswordString"]),
                                Salt = Convert.ToString(reader["Salt"])
                            }
                        );
                    }
                }
            }

            catch (SqlException ex)
            {
                throw ex;
            }

            return users;
        }
    }
}