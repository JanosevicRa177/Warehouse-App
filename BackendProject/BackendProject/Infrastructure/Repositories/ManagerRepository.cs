using BackendProject.Infrastructure.Shared;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class ManagerRepository : BaseRepository<Manager>, IManagerRepository 
{  
    private readonly MainDbContext _context;
    public ManagerRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
