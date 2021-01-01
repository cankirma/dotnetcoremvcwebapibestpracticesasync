using System.Threading.Tasks;
using core.Models;

namespace core.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}