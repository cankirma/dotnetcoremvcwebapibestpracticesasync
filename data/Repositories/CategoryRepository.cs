using core.Models;
using core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private EfContext _efContext { get => _context as EfContext; }
        public CategoryRepository(EfContext context):base(context)
        {
            
        }
        public async Task<Category> GetWithProductsByIdAsync(int categoryId) => await  _efContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == categoryId);
    }
}