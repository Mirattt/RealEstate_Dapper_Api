using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ListingRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingController : ControllerBase
    {
        private readonly IListingRepository _listingRepository;

        public ListingController(IListingRepository listingRepository)
        {
            _listingRepository = listingRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllListing()
        {
            var values = await _listingRepository.GetAllListing();
            return Ok(values);
        }

    }
}
