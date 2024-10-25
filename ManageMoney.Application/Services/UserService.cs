using AutoMapper;
using ManageMoney.Application.DTOs;
using ManageMoney.Application.Interfaces;
using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;

namespace ManageMoney.Application.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetUsers(CancellationToken cancellationToken)
        {
            var userEntities = await _userRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<UserDTO>>(userEntities);
        }

        public async Task<UserDTO> GetUser(Guid id, CancellationToken cancellationToken)
        {
            var userEntity = await _userRepository.GetIdAsync(id, cancellationToken);
            return _mapper.Map<UserDTO>(userEntity);
        }

        public async Task Add(UserDTO userDTO)
        {
            var userEntity = _mapper.Map<User>(userDTO);
             _userRepository.Create(userEntity);
        }

        public async Task Delete(Guid id, CancellationToken cancellationToken)
        {
            var userEntity = await _userRepository.GetIdAsync(id, cancellationToken);

            if (userEntity != null)
            {
                 _userRepository.Delete(userEntity);
            }
        }

        public async Task Update(UserDTO userDTO)
        {
            var userEntity = _mapper.Map<User>(userDTO);
             _userRepository.Update(userEntity);
        }
    }
}
