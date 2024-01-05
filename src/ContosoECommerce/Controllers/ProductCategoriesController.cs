using Microsoft.AspNetCore.Mvc;
using ContosoECommerce.Api.Repositories;
using Microsoft.ApplicationInsights;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {

        private readonly TelemetryClient telemetry;

        public ProductCategoriesController()
        {
            TelemetryClient telemetry = new TelemetryClient();
            this.telemetry = telemetry;
        }

        // GET: api/<ProductCategoriesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string logHeader = $"ProductCategoriesController.Get: ";
            this.telemetry.TrackTrace($"{logHeader} operation started.");

            this.telemetry.TrackTrace($"{logHeader} operation ended.");
            return new ProductRepository(this.telemetry).GetProductCategories();
        }

        //// GET api/<ProductCategoriesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ProductCategoriesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProductCategoriesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductCategoriesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
