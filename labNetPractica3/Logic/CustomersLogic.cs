using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var customerToDelete = context.Customers.Find(id);

            if (customerToDelete != null)
            {
                context.Customers.Remove(customerToDelete);
                context.SaveChanges();
            }
        }

        public void Update(string id)
        {
            var customerToUpdate = context.Customers.Find(id);
            
            if (customerToUpdate != null)
            {
                Console.WriteLine("Ingrese nuevo titulo");
                string newContactTitle = Console.ReadLine();
                customerToUpdate.ContactTitle = newContactTitle;
                context.SaveChanges();
            }
        }
    }
}
