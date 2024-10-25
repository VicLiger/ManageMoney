using AutoMapper;
using ManageMoney.Application.DTOs;
using ManageMoney.Application.Interfaces;
using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ManageMoney.Application.Services
{
    public class AccountCashService : IAccountCashService
    {
        private readonly IAccountCashRepository _accountCashRepository;
        private readonly IMapper _mapper;

        public AccountCashService(IAccountCashRepository accountCashRepository, IMapper mapper)
        {
            _accountCashRepository = accountCashRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AccountCashDTO>> GetAccountsCash(CancellationToken cancellationToken)
        {
            var accountEntity = await _accountCashRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<AccountCashDTO>>(accountEntity);
        }

        public async Task<AccountCashDTO> GetAccountsCashId(Guid id, CancellationToken cancellationToken)
        {
            var accountEntity = await _accountCashRepository.GetIdAsync(id, cancellationToken);
            return _mapper.Map<AccountCashDTO>(accountEntity);
        }

        public async Task Add(AccountCashDTO accountCashDTO)
        {
            var accountEntity = _mapper.Map<AccountCash>(accountCashDTO);
            _accountCashRepository.Create(accountEntity);
        }

        public async Task Delete(Guid id, CancellationToken cancellationToken)
        {
            var accountEntity = await _accountCashRepository.GetIdAsync(id,cancellationToken);

            if (accountEntity != null)
            {
                _accountCashRepository.Delete(accountEntity);
            }
        }

        public async Task Update(AccountCashDTO accountCashDTO)
        {
            var accountEntity = _mapper.Map<AccountCash>(accountCashDTO);
            _accountCashRepository.Update(accountEntity);
        }
    }
}
