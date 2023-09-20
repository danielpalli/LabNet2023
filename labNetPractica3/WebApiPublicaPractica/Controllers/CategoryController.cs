using Entities;
using Logic;
using Logic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Http;
using System.Web.Http.Results;
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
            bool exist = logic.findByName(dto.CategoryName);
            
            if (!exist)
            {
                logic.Insert(dto);
                return Ok(dto);
            }
            string msg = "ya existe la categoria";
            return Json(new { msg });
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
            bool exist = logic.findByName(dto.CategoryName);

            if (!exist)
            {
                bool result = logic.Update(dto);

                return Json(new { result });
            }

            string msg = "ya existe la categoria";
            return Json(new { msg });
        }
    }
}
