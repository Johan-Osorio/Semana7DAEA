using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CustomerData
    {
        public List<Customers> GetCustomers()
        {
            string connectionString = "Data Source=LAB1504-29\\SQLEXPRESS; Initial Catalog=master ;User Id=johan; Password=123456;";
            string uspp = "USP_GetCustomers";
            List<Customers> customers1 = new List<Customers>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(uspp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customers customers = new Customers
                            {
                                customer_id = Convert.ToInt32(reader["customer_id"]),
                                name = reader["name"].ToString(),
                                address = reader["address"].ToString(),
                                phone = reader["phone"].ToString(),

                            };
                            customers1.Add(customers);
                        }

                        reader.Close();
                    }
                }
                return customers1;
            }
        }
        public void Insert()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }
}
