using BackendProject.Infrastructure.Shared;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.${class.typePackage};

public class ${class.name}Repository : BaseRepository<${class.name}>, I${class.name}Repository 
{  
    private readonly MainDbContext _context;
    public ${class.name}Repository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
