

using ManageMoney.Application.DTOs;

namespace ManageMoney.Application.Interfaces
{
    public interface IAccountCashService
    {
        Task<IEnumerable<AccountCashDTO>> GetAccountsCash(CancellationToken cancellationToken);
        Task<AccountCashDTO> GetAccountsCashId(Guid id, CancellationToken cancellationToken);
        Task Add(AccountCashDTO accountCashDTO);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task Update(AccountCashDTO accountCashDTO);

    }
}
