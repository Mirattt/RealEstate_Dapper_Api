using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region Statistic1
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44310/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;
            #endregion

            #region Statistic2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44310/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData2;
            #endregion

            #region Statistic3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44310/api/Statistics/ApartmentCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.apartmentCount = jsonData3;
            #endregion

            #region Statistic4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44310/api/Statistics/AverageProductPriceByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRent = jsonData4;
            #endregion


            #region Statistic5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44310/api/Statistics/AverageProductPriceBySale");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsonData;
            #endregion

            #region Statistic6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44310/api/Statistics/AverageRoomCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsonData6;
            #endregion

            #region Statistic7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44310/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData7= await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsonData7;
            #endregion

            #region Statistic8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:44310/api/Statistics/CityNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaxProductCount = jsonData8;
            #endregion


            #region Statistic9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:44310/api/Statistics/DefferentCityCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.defferentCityCount = jsonData9;
            #endregion

            #region Statistic10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:44310/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsonData10;
            #endregion

            #region Statistic11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:44310/api/Statistics/LastProductPrice");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice = jsonData11;
            #endregion

            #region Statistic12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:44310/api/Statistics/NewestBuildingYear");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = jsonData12;
            #endregion


            #region Statistic13
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("https://localhost:44310/api/Statistics/OldestBuildingYear");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsonData13;
            #endregion

            #region Statistic14
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:44310/api/Statistics/PassiveCategoryCount");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsonData14;
            #endregion

            #region Statistic15
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:44310/api/Statistics/ProductCount");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData15;
            #endregion


            return View();
        }
    }
}
