using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        CategoryLogic logic = new CategoryLogic();
        // GET api/values
        public IHttpActionResult Get()
        {
            try
            {
                List<Entities.Categories> categories = logic.GetAll().ToList();
                List<string> categoryNames = categories.Select(c => c.CategoryName).ToList(); // Suponiendo que Category tiene una propiedad "Name".

                return Ok(categoryNames); // Devuelve una respuesta HTTP 200 (OK) con los nombres de las categorías en formato JSON.
            }
            catch (Exception ex)
            {
                // Aquí puedes manejar cualquier excepción que pueda ocurrir durante la obtención de categorías.
                // Devuelve una respuesta HTTP 500 (Error interno del servidor) con un mensaje de error en formato JSON.
                return InternalServerError(ex);
            }
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
