namespace BackendProject.Infrastructure.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T? Find(int id);

        IEnumerable<T> FindAll();

        Task<T> Create(T entity);

        void Update(T entity);
        void Delete(T entity);
    }
}
