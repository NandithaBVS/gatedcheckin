using Microsoft.ApplicationInsights;

namespace ContosoECommerce.Api.Repositories
{
    public class ProductRepository
    {
        private readonly TelemetryClient telemetryClient;

        public ProductRepository(TelemetryClient telemetryClient)
        {
            this.telemetryClient = telemetryClient;             
        }
        public IEnumerable<string> GetProducts()
        {
            string logHeader = $"ProductRepository.GetProducts: ";
            this.telemetryClient.TrackTrace($"{logHeader} operation started.");

            /// 

            this.telemetryClient.TrackTrace($"{logHeader} operation ended.");
            return new string[] { "Shoes", "Shirts", "Laptops", "Mugs", "Bags" };
        }
        public IEnumerable<string> GetProductCategories()
        {
            string logHeader = $"ProductRepository.GetProductCategories: ";
            this.telemetryClient.TrackTrace($"{logHeader} operation started.");

            /// 

            this.telemetryClient.TrackTrace($"{logHeader} operation ended.");
            return new string[] { "FashionAccessories", "Clothing", "Electronics", "Home", "Travel" };
        }
    }
}
