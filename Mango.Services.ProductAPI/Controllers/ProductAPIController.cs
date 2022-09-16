using Mango.Services.ProductAPI.Models.Dtos;
using Mango.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        protected ResponseDto response;
        readonly IProductRepository repository;
        public ProductAPIController(IProductRepository repository)
        {
            response = new ResponseDto
            {
                IsSuccess = false,
                ErrorMessages = new List<string>(),
                DisplayMessage = string.Empty,
                Result = null
            };
            this.repository = repository;
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                var products = await repository.GetProducts();
                response.IsSuccess = true;
                response.Result = products;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.Message };
            }
            return response;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                var product = await repository.GetProductById(id);
                response.IsSuccess = true;
                response.Result = product;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.Message };
            }
            return response;
        }

        [HttpPost]
        public async Task<object> Post([FromBody] ProductDto productDto)
        {
            try
            {
                var product = await repository.CreateUpdateProduct(productDto);
                response.IsSuccess = true;
                response.Result = product;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.Message };
            }
            return response;
        }

        [HttpPut]
        public async Task<object> Put([FromBody] ProductDto productDto)
        {
            try
            {
                var product = await repository.CreateUpdateProduct(productDto);
                response.IsSuccess = true;
                response.Result = product;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.Message };
            }
            return response;
        }

        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                var isSuccess= await repository.DeleteProduct(id);
                response.IsSuccess = true;
                response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.Message };
            }
            return response;
        }
    }
}
