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
    internal class InvestimentService : IInvestimentService
    {
        private readonly IInvestimentRepository _investimentRepository;
        private readonly IMapper _mapper;

        public InvestimentService(IInvestimentRepository investimentRepository, IMapper mapper)
        {
            _investimentRepository = investimentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InvestimentDTO>> GetInvestiments(CancellationToken cancellationToken)
        {
            var investimentEntities = await _investimentRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<InvestimentDTO>>(investimentEntities);
        }

        public async Task<InvestimentDTO> GetInvestiment(Guid id, CancellationToken cancellationToken)
        {
            var investimentEntity = await _investimentRepository.GetIdAsync(id, cancellationToken);
            return _mapper.Map<InvestimentDTO>(investimentEntity);
        }

        public async Task Add(InvestimentDTO investimentDTO)
        {
            var investimentEntity = _mapper.Map<Investiment>(investimentDTO);
             _investimentRepository.Create(investimentEntity);
        }

        public async Task Delete(Guid id, CancellationToken cancellationToken)
        {
            var investimentEntity = await _investimentRepository.GetIdAsync(id, cancellationToken);

            if (investimentEntity != null)
            {
                 _investimentRepository.Delete(investimentEntity);
            }
        }

        public async Task Update(InvestimentDTO investimentDTO)
        {
            var investimentEntity = _mapper.Map<Investiment>(investimentDTO);
            _investimentRepository.Update(investimentEntity);
        }
    }
}
