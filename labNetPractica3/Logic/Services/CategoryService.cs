using Entities;
using Logic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CategoryService : BaseLogic
    {
        public List<CategoryDto> GetAll()
        {
            IEnumerable<Categories> categories = context.Categories.AsEnumerable();
            List<CategoryDto> result = categories.Select(c => new CategoryDto
            {
                Id = c.CategoryID,
                CategoryName = c.CategoryName,
                Description = c.Description,
            }).ToList();

            return result;
        }

        public bool Insert(CategoryDto dto)
        {
            var newCategory = new Categories()
            {
                CategoryName = dto.CategoryName,
                Description = dto.Description,
            };
            context.Categories.Add(newCategory);

            return context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            bool result = false;
            Categories category = context.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (category != null)
            {
                context.Categories.Remove(category);
                result = context.SaveChanges() > 0;
            }
            return result;
        }

        public bool Update(CategoryDto dto)
        {
            bool result = false;

            Categories categories = context.Categories.FirstOrDefault(c => c.CategoryID == dto.Id);
            if (categories != null)
            {
                categories.CategoryName = dto.CategoryName;
                categories.Description = dto.Description;
                result = context.SaveChanges() > 0;
            }

            return result;
        }

    }
}
