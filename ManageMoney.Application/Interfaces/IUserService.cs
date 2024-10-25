
using ManageMoney.Application.DTOs;

namespace ManageMoney.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetUsers(CancellationToken cancellationToken);
        Task<UserDTO> GetUser(Guid id, CancellationToken cancellationToken);
        Task Add(UserDTO userDTO);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task Update(UserDTO userDTO);
    }
}
