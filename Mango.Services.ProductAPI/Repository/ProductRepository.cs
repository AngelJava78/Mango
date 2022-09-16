using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        readonly ApplicationDbContext db;
        readonly IMapper mapper;
        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            var product = mapper.Map<ProductDto, Product>(productDto);
            if(product.ProductId >0)
            {
                db.Products.Update(product);
                
            }
            else
            {
                db.Products.Add(product);
            }
            await db.SaveChangesAsync();
            return mapper.Map<Product,ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var result = false;
            try
            {
                var product = await db.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
                if (product == null)
                {
                    result = false;
                }
                else
                {
                    db.Products.Remove(product);
                    await db.SaveChangesAsync();
                    result = true;
                }
            }
            catch (Exception)
            {
                result=  false;
            }
            return result;
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            var product = await db.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
            return mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var products = await db.Products.ToListAsync();
            return mapper.Map<List<ProductDto>>(products);
        }
    }
}
