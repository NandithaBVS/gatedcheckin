using Newtonsoft.Json;
using NUnit.Framework.Internal;
using RestSharp;
using System;
using System.Xml;


namespace ContosoECommerce.Api.Tests
{
    [TestFixture]
    public class UATTests
    {
        [Test]
        public void GetProductTestAvailable()
        {
            var webApiClient = new RestClient("https://contosoecommerceapi20231026165901.azurewebsites.net");
            var request = new RestRequest("api/Products", Method.GET);
            var response = webApiClient.Execute(request);
            // Assert it's response
            Assert.IsTrue(response.Content.Contains("Bags"));
        }
        [Test]
        public void GetProductTestNotAvailable()
        {
            var webApiClient = new RestClient("https://contosoecommerceapi20231026165901.azurewebsites.net");
            var request = new RestRequest("api/Products", Method.GET);
            var response = webApiClient.Execute(request);

            // Assert it's response
            Assert.IsFalse(response.Content.Contains("Pants"));
        }
        [Test]
        public void GetProductCategoriesTestAvailable()
        {
            var webApiClient = new RestClient("https://contosoecommerceapi20231026165901.azurewebsites.net");
            var request = new RestRequest("api/ProductCategories", Method.GET);
            var response = webApiClient.Execute(request);

            // Assert it's response
            Assert.IsTrue(response.Content.Contains("FashionAccessories"));
        }
        [Test]
        public void GetProductCategoriesTestNotAvailable()
        {
            var webApiClient = new RestClient("https://contosoecommerceapi20231026165901.azurewebsites.net");
            var request = new RestRequest("api/ProductCategories", Method.GET);
            var response = webApiClient.Execute(request);

            // Assert it's response
            Assert.IsFalse(response.Content.Contains("KitchenTools"));
        }
        [Test]
        public void GetSellersTestNotAvailable()
        {
            var webApiClient = new RestClient("https://contosoecommerceapi20231026165901.azurewebsites.net");
            var request = new RestRequest("api/Sellers", Method.GET);
            var response = webApiClient.Execute(request);

            // Assert it's response
            Assert.IsFalse(response.Content.Contains("Dell"));
        }
        [Test]
        public void GetSellersTestAvailable()
        {
            var webApiClient = new RestClient("https://contosoecommerceapi20231026165901.azurewebsites.net");
            var request = new RestRequest("api/Sellers", Method.GET);
            var response = webApiClient.Execute(request);

            // Assert it's response
            Assert.IsTrue(response.Content.Contains("Lenevo"));
        }
        [Test]
        public void GetWeatherForecastTestAvailable()
        {
            var webApiClient = new RestClient("https://contosoecommerceapi20231026165901.azurewebsites.net");
            var request = new RestRequest("WeatherForecast", Method.GET);
            var response = webApiClient.Execute(request);
            // Assert it's response
            Assert.IsNotNull(response);
        }
    }
}