using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CustomersBusiness
    {
        public List<Customers> GetCustomers()
        {
            List<Customers> customers = new List<Customers>();
            CustomerData data = new CustomerData();
            customers = data.GetCustomers();
            return customers;
        }
    }
}
