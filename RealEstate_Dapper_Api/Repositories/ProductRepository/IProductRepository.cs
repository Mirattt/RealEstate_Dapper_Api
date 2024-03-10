using RealEstate_Dapper_Api.Dtos.ProductDtos;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDtos>> GetAllProductAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsync(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();

        void ProductDealOfTheDayStatusChangeToTrue(int id);
        void ProductDealOfTheDayStatusChangeToFalse(int id);
        Task<List<ResultProductDtos>> GetLast5ProductAsync();
        void DeleteProduct(int id);
        void UpdateProduct(UpdateProductDto updateProductDto);
        void CreateProduct(CreateProductDto createProductDto);
        Task<GetByIdProductDto> GetIdProduct(int id);




    }
}
