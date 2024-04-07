using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository 
{  
    private readonly MainDbContext _context;
    public ProductRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
    
    public override Product? Find(int id)
    {
        return _context.Products
	    .Include(x => x.Item)
	    .Include(x => x.Warehouse)
        .FirstOrDefault(x => x.Id == id);
    }
    public override IEnumerable<Product> FindAll()
    {
        return _context.Products
	    .Include(x => x.Item)
	    .Include(x => x.Warehouse)
        .ToList();
    }
}
