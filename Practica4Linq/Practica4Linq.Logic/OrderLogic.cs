using Practica4Linq.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Linq.Logic
{
    public class OrderLogic : BaseLogic
    {
        public List<Orders> GetCustomersInWAWithOrdersAfter1997()
        {
            var customers = context.Customers
            .Where(c => c.Region == "WA")
                .Join(
                    context.Orders,
                    customer => customer.CustomerID,
                    order => order.CustomerID,
                    (customer, order) => order)
                .Where(order => order.OrderDate > new DateTime(1997, 1, 1))
                .ToList();

            return customers;
        }
    }
}
