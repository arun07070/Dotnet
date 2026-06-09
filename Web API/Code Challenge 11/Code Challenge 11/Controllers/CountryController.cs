using Code_Challenge_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Code_Challenge_11.Controllers
{
    public class CountryController : ApiController
    {
        static List<Country> countries = new List<Country>()
        {
            new Country{ ID=1, CountryName="India", Capital="New Delhi"},
            new Country{ ID=2, CountryName="USA", Capital="Washington"}
        };
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();
            return Ok(country);
        }
        [HttpPost]
        public IHttpActionResult Post(Country country)
        {
            countries.Add(country);
            return Ok("Country Added Successfully");
        }
        [HttpPut]
        public IHttpActionResult Put(int id, Country country)
        {
            var c = countries.FirstOrDefault(x => x.ID == id);
            if (c == null)
                return NotFound();
            c.CountryName = country.CountryName;
            c.Capital = country.Capital;
            return Ok("Country Updated Successfully");
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var c = countries.FirstOrDefault(x => x.ID == id);
            if (c == null)
                return NotFound();
            countries.Remove(c);
            return Ok("Country Deleted Successfully");
        }
    }
}