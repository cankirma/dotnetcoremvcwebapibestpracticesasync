using System.Threading.Tasks;
using core.Models;

namespace core.Services
{
    public interface IProductService:IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);

    }
}