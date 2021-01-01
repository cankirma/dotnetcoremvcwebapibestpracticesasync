using System.Threading.Tasks;
using core.Models;
using core.Repositories;
using data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace data.Repositories
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        private   EfContext _efContext { get=>_context as EfContext;}
        public ProductRepository(EfContext context ) : base(context)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
          return  await _efContext.Products.Include(x => x.Category).FirstOrDefaultAsync(x=>x.Id == productId);
        }
    }
}