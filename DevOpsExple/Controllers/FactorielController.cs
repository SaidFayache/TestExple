using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevOpsExple.Controllers
{
    [ApiController]
    [Route("factoriel")]
    public class FactorielController : ControllerBase
    {

        // GET api/<FactorielController>/5
        [HttpGet]
        public string Get([FromQuery(Name = "n")] string n)
        {
            int num = int.Parse(n);
            int fact = num--;
            while(num > 0)
            {
                fact *= num--;
            }
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("result", fact);
            return JsonConvert.SerializeObject(myDictionary);
        }

        // POST api/<FactorielController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FactorielController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FactorielController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
