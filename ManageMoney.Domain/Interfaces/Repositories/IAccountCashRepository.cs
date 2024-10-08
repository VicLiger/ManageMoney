using ManageMoney.Domain.Entities;

namespace ManageMoney.Domain.Interfaces.Repositories
{
    public interface IAccountCashRepository 
    {
        Task<IEnumerable<AccountCash>> GetAllAsync(CancellationToken cancellationToken);
        Task<AccountCash> GetIdAsync(Guid id, CancellationToken cancellationToken);
        void Create(AccountCash accountCash);
        void Delete(AccountCash accountCash);
        void Update(AccountCash accountCash);
    }
}
