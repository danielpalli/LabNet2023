﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiPublicaPractica.Models.Dto;

namespace WebApiPublicaPractica.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly HttpClient httpClient;

        public ValuesController()
        {
            httpClient = new HttpClient();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetData()
        {
            string url = "https://api.covidtracking.com/v1/us/daily.json";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        List<CovidDataDto> covidData = JsonConvert.DeserializeObject<List<CovidDataDto>>(jsonResponse);

                        return Ok(covidData);
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

