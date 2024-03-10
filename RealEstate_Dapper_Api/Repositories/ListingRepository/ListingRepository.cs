using Dapper;
using RealEstate_Dapper_Api.Dtos.ListingDto;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ListingRepository
{
    public class ListingRepository:IListingRepository
    {
        private readonly Context _context;
    

        public ListingRepository(Context context)
        {
            _context = context;
            
        }

        public async Task<List<ResultListingDto>> GetAllListing()
        {

            string query = "Select \r\nPrice,City,District,Title,CoverImage,Gorev,Description,Adress,ProductSize,BedRoomCount,BathCount,Name\r\nfrom Product\r\ninner join Employee on Product.EmployeeID=Employee.EmployeeID\r\ninner join ProductDetails on Product.ProductID=ProductDetailID;";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultListingDto>(query);
                return values.ToList();
            }


        }
    }
}
