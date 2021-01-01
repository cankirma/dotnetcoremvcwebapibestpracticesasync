using System.Threading.Tasks;
using core.Models;

namespace core.Services
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);


    }
}