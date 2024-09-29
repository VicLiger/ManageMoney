namespace ManageMoney.Domain.Interfaces
{
    public interface IBasicImplemention<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken);
        Task<T> GetById(Guid Id, CancellationToken cancellationToken);
        void Update(T t);
        void Create(T t);
        void Delete(Guid id);

    }
}
