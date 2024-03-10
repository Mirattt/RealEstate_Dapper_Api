using RealEstate_Dapper_Api.Dtos.EmployeeDtos;
using RealEstate_Dapper_Api.Dtos.ListingDto;

namespace RealEstate_Dapper_Api.Repositories.ListingRepository
{
    public interface IListingRepository
    {
        public Task<List<ResultListingDto>> GetAllListing();
    }
}
