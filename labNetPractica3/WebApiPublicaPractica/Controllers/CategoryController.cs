using Entities;
using Logic;
using Logic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiPublicaPractica.Models;

namespace WebApiPublicaPractica.Controllers
{
    public class CategoryController : ApiController
    {
        CategoryService logic = new CategoryService();

        [HttpGet]
        public List<CategoryDto> Get()
        {
            List<CategoryDto> result = logic.GetAll();

            return result;
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            CategoryDto category = logic.GetById(id);

            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IHttpActionResult Post(CategoryDto dto)
        {
            logic.Insert(dto);
            return Ok(dto);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            bool result = logic.Delete(id);

            return Json(new { result });

        }

        [HttpPut]
        public IHttpActionResult Put(CategoryDto dto)
        {
            bool result = logic.Update(dto);

            return Json(new { result });
        }
    }
}
