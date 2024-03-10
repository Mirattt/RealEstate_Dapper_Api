using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Repositories.ProductRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }

        //[HttpGet("ProductListWithCategory")]
        //public async Task<IActionResult> ProductListWithCategory()
        //{
        //    var values = await _productRepository.GetAllProductWithCategoryAsync();
        //    return Ok(values);
        //}
        [HttpGet("ProductDealOfTheDayStatusChangeToTrue/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToTrue(id);
            return Ok("Ilan gunu firsatlarina eklendi");
        }

        [HttpGet("ProductDealOfTheDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToFalse(id);
            return Ok("Ilan gunu firsatlarindan cikarildi");
        }

        [HttpGet("Last5ProductList")]
        public async Task<IActionResult> Last5ProductList()
        {
            var values = await _productRepository.GetLast5ProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductAdvertsListByEmployee")]
        public async Task<IActionResult> ProductAdvertsListByEmployee(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAsync(id);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
            return Ok("Basarili bir sekilde silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productRepository.UpdateProduct(updateProductDto);
            return Ok("Kategori Basariyla Guncellendi");
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            _productRepository.CreateProduct(createProductDto);
            return Ok("Basarili bir sekilde eklendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetIdProduct(int id)
        {
            var value = await _productRepository.GetIdProduct(id);
            return Ok(value);
        }
    }
}

