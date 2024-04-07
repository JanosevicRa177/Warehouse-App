using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class WarehouseRepository : BaseRepository<Warehouse>, IWarehouseRepository 
{  
    private readonly MainDbContext _context;
    public WarehouseRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
    
    public override Warehouse? Find(int id)
    {
        return _context.Warehouses
	    .Include(x => x.ReceiptItems)
	    .Include(x => x.Address)
	    .Include(x => x.Products)
	    .Include(x => x.Workers)
        .FirstOrDefault(x => x.Id == id);
    }
    public override IEnumerable<Warehouse> FindAll()
    {
        return _context.Warehouses
	    .Include(x => x.ReceiptItems)
	    .Include(x => x.Address)
	    .Include(x => x.Products)
	    .Include(x => x.Workers)
        .ToList();
    }
}
