using Practica4Linq.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Linq.Logic
{
    public class CustomerLogic : BaseLogic, IABMLogic<Customers>
    {
        public Customers GetElementById(string id)
        {
            var customer = context.Customers
                .Where(c => c.CustomerID.Equals(id))
                .FirstOrDefault();
            return customer;
        }
      
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        public List<Customers> GetCustomerRegion(string region)
        {
            var customersRegion = context.Customers
                .Where(c => c.Region.Equals(region))
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
            var lowerNames = context.Customers
                .Select(c => c.ContactName.ToLower())
                .ToList();
            return lowerNames;
        }
    }
}
