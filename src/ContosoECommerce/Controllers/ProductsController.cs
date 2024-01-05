using ContosoECommerce.Api.Repositories;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly TelemetryClient telemetry;

        public ProductsController()
        {
            TelemetryClient telemetry = new TelemetryClient();
            this.telemetry = telemetry;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string logHeader = $"ProductsController.Get: ";
            this.telemetry.TrackTrace($"{logHeader} operation started.");

            this.telemetry.TrackTrace($"{logHeader} operation ended.");
            return new ProductRepository(this.telemetry).GetProducts();
        }

        //// POST api/<ProductsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProductsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
