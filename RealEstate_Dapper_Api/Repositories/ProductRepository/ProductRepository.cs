using Dapper;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async void CreateProduct(CreateProductDto createProductDto)
        {
            string query = "Insert into Product (Title,Price,City,District,CoverImage,Description,ProductCategory,Adress) " +
                "values (@title,@price,@city,@district,@coverImage,@description,@productCategory,@adress)";


            var parameters = new DynamicParameters();
            parameters.Add("@title", createProductDto.Title);
            parameters.Add("@price", createProductDto.Price);
            parameters.Add("@city", createProductDto.City);
            parameters.Add("@district", createProductDto.District);
            parameters.Add("@coverImage", createProductDto.CoverImage);
            parameters.Add("@description", createProductDto.Description);
            parameters.Add("@productCategory", createProductDto.ProductCategory);
            parameters.Add("@adress", createProductDto.Adress);




            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteProduct(int id)
        {
            string query = "Delete From Product Where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultProductDtos>> GetAllProductAsync()
        {
            string query = "Select a.*,b.CategoryName From Product as a LEFT JOIN Category as b ON b.CategoryID = a.ProductCategory";
           // string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDtos>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Description,Adress,DealOfTheDay " +
                "from Product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdProductDto> GetIdProduct(int id)
        {
            string query = "Select * From Product Where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("productID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdProductDto>(query, parameters);
                return values;
            }
        }

        public async Task<List<ResultProductDtos>> GetLast5ProductAsync()
        {
            string query = "Select Top(5) * From Product Where Description='Satilik' Order By ProductID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDtos>(query);
                return values.ToList();
            }
        }


        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsync(int id)
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Description,Adress,DealOfTheDay from Product " +
                "inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeId=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }

        public async void ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set DealOfTheDay=0 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set DealOfTheDay=1 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void UpdateProduct(UpdateProductDto updateProductDto)
        {
            // string query = "Update Product Set Title=@title,Price=@price, City=@city,District=@district,CoverImage=@coverImage,Description=@description,Adress=@adress where ProductID=@productID";
            string query = "Update Product Set  Title=@title,Price=@price, City=@city,District=@district,CoverImage=@coverImage," +
                "Description=@description,Adress=@adress,ProductCategory=@productCategory " +
                "from Product  Where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateProductDto.Title);
            parameters.Add("@price", updateProductDto.Price);
            parameters.Add("@city", updateProductDto.City);
            parameters.Add("@district", updateProductDto.District);
            parameters.Add("@coverImage", updateProductDto.CoverImage);
            parameters.Add("@description", updateProductDto.Description);
            parameters.Add("@adress", updateProductDto.Adress);
            parameters.Add("@productCategory", updateProductDto.ProductCategory);
            parameters.Add("@productID", updateProductDto.ProductID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
