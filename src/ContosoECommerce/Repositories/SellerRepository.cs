using Microsoft.ApplicationInsights;

namespace ContosoECommerce.Api.Repositories
{
    public class SellerRepository
    {
        private readonly TelemetryClient telemetryClient;

        public SellerRepository(TelemetryClient telemetryClient)
        {
            this.telemetryClient = telemetryClient;             
        }
        public IEnumerable<string> GetSellers()
        {
            string logHeader = $"SellerRepository.GetSellers: ";
            this.telemetryClient.TrackTrace($"{logHeader} operation started.");

            /// 

            this.telemetryClient.TrackTrace($"{logHeader} operation ended.");
            return new string[] { "Bata", "LV", "Jack&Jones", "HP","Lenevo", "StarBucks", "SkyBags", "Safari" };
        }
    }
}
