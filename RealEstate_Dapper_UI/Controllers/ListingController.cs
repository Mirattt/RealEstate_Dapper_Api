using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.ListingDtos;

namespace RealEstate_Dapper_UI.Controllers
{
    public class ListingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ListingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44310/api/Listing");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultListingDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

