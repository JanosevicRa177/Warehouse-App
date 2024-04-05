using BackendProject.Infrastructure.Shared;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository 
{  
    private readonly MainDbContext _context;
    public UserRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
