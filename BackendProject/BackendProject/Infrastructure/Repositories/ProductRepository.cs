using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository 
{  
    private readonly MainDbContext _context;
    public ProductRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
