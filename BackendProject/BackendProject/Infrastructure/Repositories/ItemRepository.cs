using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class ItemRepository : BaseRepository<Item>, IItemRepository 
{  
    private readonly MainDbContext _context;
    public ItemRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
