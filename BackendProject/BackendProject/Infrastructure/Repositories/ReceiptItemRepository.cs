using BackendProject.Infrastructure.Shared;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class ReceiptItemRepository : BaseRepository<ReceiptItem>, IReceiptItemRepository 
{  
    private readonly MainDbContext _context;
    public ReceiptItemRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
