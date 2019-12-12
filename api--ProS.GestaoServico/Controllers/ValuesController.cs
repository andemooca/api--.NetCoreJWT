using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api__ProS.GestaoServico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ProSLogger logger = new ProSLogger();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                //logger.Info("Values", "Método Get - Infor");
                //logger.Debug("Values", "Método Get - DEBUG");

                return new string[] { "value1", "value2" };
            }
            catch (System.Exception ex)
            {
                //logger.Error("Values", "Método Get - Error" , ex);

                throw;
            }
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
