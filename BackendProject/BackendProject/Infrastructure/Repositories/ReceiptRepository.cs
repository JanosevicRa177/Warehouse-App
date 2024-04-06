using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class ReceiptRepository : BaseRepository<Receipt>, IReceiptRepository 
{  
    private readonly MainDbContext _context;
    public ReceiptRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
