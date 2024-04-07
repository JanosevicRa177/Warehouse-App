using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class ReceiptRepository : BaseRepository<Receipt>, IReceiptRepository 
{  
    private readonly MainDbContext _context;
    public ReceiptRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
    
    public override Receipt? Find(int id)
    {
        return _context.Receipts
	    .Include(x => x.ReceiptItems)
	    .Include(x => x.ReceiptItems)
        .FirstOrDefault(x => x.Id == id);
    }
    public override IEnumerable<Receipt> FindAll()
    {
        return _context.Receipts
	    .Include(x => x.ReceiptItems)
	    .Include(x => x.ReceiptItems)
        .ToList();
    }
}
