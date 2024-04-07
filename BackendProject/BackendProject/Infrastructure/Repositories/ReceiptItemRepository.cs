using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class ReceiptItemRepository : BaseRepository<ReceiptItem>, IReceiptItemRepository 
{  
    private readonly MainDbContext _context;
    public ReceiptItemRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
    
    public override ReceiptItem? Find(int id)
    {
        return _context.ReceiptItems
	    .Include(x => x.Item)
	    .Include(x => x.Receipts)
	    .Include(x => x.Warehouse)
        .FirstOrDefault(x => x.Id == id);
    }
    public override IEnumerable<ReceiptItem> FindAll()
    {
        return _context.ReceiptItems
	    .Include(x => x.Item)
	    .Include(x => x.Receipts)
	    .Include(x => x.Warehouse)
        .ToList();
    }
}
