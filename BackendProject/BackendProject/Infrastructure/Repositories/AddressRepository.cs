using BackendProject.Infrastructure.Shared;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class AddressRepository : BaseRepository<Address>, IAddressRepository 
{  
    private readonly MainDbContext _context;
    public AddressRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
