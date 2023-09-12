using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CategoryLogic : BaseLogic
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
        public void Add(Categories categories)
        {
            context.Categories.Add(categories);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var categoryToDelete = context.Categories.Find(id);

            if (categoryToDelete != null)
            {
                context.Categories.Remove(categoryToDelete);
                context.SaveChanges();
            }
        }

        public void Update(int id)
        {
            var categoryToUpdate = context.Categories.Find(id);

            if (categoryToUpdate != null)
            {
                Console.WriteLine("Ingrese nueva categoria");
                string newCategoryName = Console.ReadLine();
                categoryToUpdate.CategoryName = newCategoryName;
                Console.WriteLine("Ingrese nuevo titulo");
                string newDescription = Console.ReadLine();
                categoryToUpdate.Description = newDescription;
                context.SaveChanges();
            }
        }
    }
}
