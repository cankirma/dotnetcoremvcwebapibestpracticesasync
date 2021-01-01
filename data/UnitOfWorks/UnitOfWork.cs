using System.Threading.Tasks;
using core.Repositories;
using core.UnitOfWorks;
using data.Contexts;
using data.Repositories;

namespace data.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly EfContext _context;

        public UnitOfWork(EfContext context)
        {
            _context = context;
        }

        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Categories =>
            _categoryRepository = _categoryRepository ?? new CategoryRepository(_context); 
        public async Task CommitAsync()
        {
            _context.SaveChangesAsync();
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}