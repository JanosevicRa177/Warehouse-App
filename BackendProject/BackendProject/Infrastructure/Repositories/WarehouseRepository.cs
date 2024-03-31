using BackendProject.Infrastructure.Shared;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class WarehouseRepository : BaseRepository<Warehouse>, IWarehouseRepository 
{  
    private readonly MainDbContext _context;
    public WarehouseRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
