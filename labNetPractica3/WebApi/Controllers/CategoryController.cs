using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Entities;
using Logic;
using Entities.Dto;

namespace WebApi.Controllers
{
    public class CategoryController : ApiController
    {
        CategoryLogic logic = new CategoryLogic();

        // GET: Category
        public IHttpActionResult Get()
        {
            try
            {
                List<Categories> categories = logic.GetAll();
                List<Entities.Dto.CategoryDto> categoriesModel = categories.Select(e => new CategoryDto
                {
                    Id = e.CategoryID,
                    CategoryName = e.CategoryName,
                    Description = e.Description
                }).ToList();

                return Ok(categoriesModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
       
    }
}