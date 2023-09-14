using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApiPublicaPractica.Models.Dto;

namespace WebApiPublicaPractica.Controllers
{
    public class ApiPublicaController : Controller
    {
        // GET: ApiPublica
        public ActionResult Index()
        {
            List<CovidDataDto> covidData = ObtenerDatosCovid();
            return View(covidData);
        }

        private List<CovidDataDto> ObtenerDatosCovid()
        {
            string url = "https://api.covidtracking.com/v1/us/daily.json";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = response.Content.ReadAsStringAsync().Result;
                        List<CovidDataDto> covidData = JsonConvert.DeserializeObject<List<CovidDataDto>>(jsonResponse);

                        return covidData;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}