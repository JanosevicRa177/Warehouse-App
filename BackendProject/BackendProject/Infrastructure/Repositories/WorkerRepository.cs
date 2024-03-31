using BackendProject.Infrastructure.Shared;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Repositories;

public class WorkerRepository : BaseRepository<Worker>, IWorkerRepository 
{  
    private readonly MainDbContext _context;
    public WorkerRepository(MainDbContext context) : base(context)
    {
        _context = context;
    }
}
