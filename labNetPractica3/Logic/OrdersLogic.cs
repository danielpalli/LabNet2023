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

        public void Delete(int id)
        {
            var orderToDelete = context.Orders.Find(id);
            if (orderToDelete != null)
            {
                context.Orders.Remove(orderToDelete);
                context.SaveChanges(); 
            }
        }
        public void Update(Orders order)
        {
            var orderUpdate = context.Orders.Find(order.OrderID);

            if (orderUpdate != null)
            {
                orderUpdate.Order_Details = order.Order_Details;
                context.SaveChanges();
            }
        }
    }
}
