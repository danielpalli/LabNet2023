using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class OrdersLogic: BaseLogic, IABMLogic<Orders>
    {
        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public void Add(Orders newOrder)
        { 
            context.Orders.Add(newOrder);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var orderToDelete = context.Orders.Find(id);
            if (orderToDelete != null)
            {
                context.Orders.Remove(orderToDelete);
                context.SaveChanges(); 
            }
        }
        public void Update(string id)
        {
          throw new NotImplementedException();
        }
    }
}
