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
    public class ProductLogic : BaseLogic, IABMLogic<Products>
    {
    
        public List<Products> GetProductsWithOutStock()
        {
            var productsWithOutStock = context.Products
                .Where(p => p.UnitsInStock == 0)
                .ToList();
            return productsWithOutStock;
        }
        public List<Products> GetProductsWithStockAndHigherPrice()
        {
            var productsWithStockAndHigherPrice = context.Products
                .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3)
                .ToList();
            return productsWithStockAndHigherPrice;
        }
        public Products GetFirstElementOrNull()
        {
            var productWithId789 = context.Products
                .FirstOrDefault(p => p.ProductID == 789);
            if (productWithId789 == null)
            {
                return null;
            }
            return productWithId789;
        }
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        Products IABMLogic<Products>.GetElementById(string id)
        {
            throw new NotImplementedException();
        }

    }
}
