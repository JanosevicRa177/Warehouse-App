using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository 
{  
    private readonly MainDbContext _context;
    public UserRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
    
    public override User? Find(int id)
    {
        return _context.Users
	    .Include(x => x.Address)
	    .Include(x => x.Warehouse)
        .FirstOrDefault(x => x.Id == id);
    }
    public override IEnumerable<User> FindAll()
    {
        return _context.Users
	    .Include(x => x.Address)
	    .Include(x => x.Warehouse)
        .ToList();
    }
}
