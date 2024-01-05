using ContosoECommerce.Api.Repositories;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        private readonly TelemetryClient telemetry;

        public SellersController()
        {
            TelemetryClient telemetry = new TelemetryClient();
            this.telemetry = telemetry;
        }
        // GET: api/<SellersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string logHeader = $"SellersController.Get: ";
            this.telemetry.TrackTrace($"{logHeader} operation started.");

            this.telemetry.TrackTrace($"{logHeader} operation ended.");
            return new SellerRepository(this.telemetry).GetSellers();
        }

        //// GET api/<SellersController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<SellersController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<SellersController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<SellersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
