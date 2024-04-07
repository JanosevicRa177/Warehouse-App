using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class AddressRepository : BaseRepository<Address>, IAddressRepository 
{  
    private readonly MainDbContext _context;
    public AddressRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
    
    public override Address? Find(int id)
    {
        return _context.Addresses
        .FirstOrDefault(x => x.Id == id);
    }
    public override IEnumerable<Address> FindAll()
    {
        return _context.Addresses
        .ToList();
    }
}
