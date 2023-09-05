using Practica4Linq.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Linq.Logic
{
    public class CustomerLogic : BaseLogic, IABMLogic<Customers>
    {
        public Customers GetElementById(string id)
        {
            var customer = (from c in context.Customers
                            where c.CustomerID.Equals(id)
                            select c)
                           .FirstOrDefault();
            return customer;
        }
      
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        public List<Customers> GetCustomerRegion(string region)
        {
            var customersRegion = (from c in context.Customers
                                   where c.Region.Equals(region)
                                   select c)
                                  .ToList();
            return customersRegion;
        }
        public List<string> GetUpperName()
        {
            var upperNames = context.Customers
                .Select(c => c.ContactName.ToUpper())
                .ToList();
            return upperNames;
        }
        public List<string> GetLowerName()
        {
            var lowerNames = (from c in context.Customers
                              select c.ContactName.ToLower())
                             .ToList();
            return lowerNames;
        }

        public List<Customers> GetfirstThreeCustomersInWa()
        {
            var customers = (from c in context.Customers
                             where c.Region == "WA"
                             select c)
                            .Take(3)
                            .ToList();
            return customers;
        }
    }
}
