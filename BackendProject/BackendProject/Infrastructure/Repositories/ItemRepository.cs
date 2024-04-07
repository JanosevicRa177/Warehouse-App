using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class ItemRepository : BaseRepository<Item>, IItemRepository 
{  
    private readonly MainDbContext _context;
    public ItemRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
    
    public override Item? Find(int id)
    {
        return _context.Items
	    .Include(x => x.Products)
	    .Include(x => x.ReceiptItems)
        .FirstOrDefault(x => x.Id == id);
    }
    public override IEnumerable<Item> FindAll()
    {
        return _context.Items
	    .Include(x => x.Products)
	    .Include(x => x.ReceiptItems)
        .ToList();
    }
}
