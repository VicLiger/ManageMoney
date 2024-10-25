using AutoMapper;
using ManageMoney.Application.DTOs;
using ManageMoney.Application.Interfaces;
using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ManageMoney.Application.Services
{
    public class ConsumptionService : IConsumptionService
    {
        private readonly IConsumptionRepository _consumptionRepository;
        private readonly IMapper _mapper;

        public ConsumptionService(IConsumptionRepository consumptionRepository, IMapper mapper)
        {
            _consumptionRepository = consumptionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ConsumptionDTO>> GetConsumptions(CancellationToken cancellationToken)
        {
            var consumptionEntities = await _consumptionRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<ConsumptionDTO>>(consumptionEntities);
        }

        public async Task<ConsumptionDTO> GetConsumption(Guid id, CancellationToken cancellationToken)
        {
            var consumptionEntity = await _consumptionRepository.GetIdAsync(id, cancellationToken);
            return _mapper.Map<ConsumptionDTO>(consumptionEntity);
        }

        public async Task Add(ConsumptionDTO consumptionDTO)
        {
            var consumptionEntity = _mapper.Map<Consumption>(consumptionDTO);
            _consumptionRepository.Create(consumptionEntity);
        }

        public async Task Delete(Guid id, CancellationToken cancellationToken)
        {
            var consumptionEntity = await _consumptionRepository.GetIdAsync(id, cancellationToken);
            if (consumptionEntity != null)
            {
                _consumptionRepository.Delete(consumptionEntity);
            }
        }

        public async Task Update(ConsumptionDTO consumptionDTO)
        {
            var consumptionEntity = _mapper.Map<Consumption>(consumptionDTO);
            _consumptionRepository.Update(consumptionEntity);
        }
    }
}
