using AutoMapper;
using ManageMoney.Application.DTOs;
using ManageMoney.Application.Interfaces;
using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;

namespace ManageMoney.Application.Services
{
    public class FinancialObjectiveService : IFinancialObjectiveService
    {
        private readonly IFinancialObjectiveRepository _financialObjectiveRepository;
        private readonly IMapper _mapper;

        public FinancialObjectiveService(IFinancialObjectiveRepository financialObjectiveRepository, IMapper mapper)
        {
            _financialObjectiveRepository = financialObjectiveRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FinancialObjectiveDTO>> GetFinancialObjectives(CancellationToken cancellationToken)
        {
            var financialObjectiveEntities = await _financialObjectiveRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<FinancialObjectiveDTO>>(financialObjectiveEntities);
        }

        public async Task<FinancialObjectiveDTO> GetFinancialObjective(Guid id, CancellationToken cancellationToken)
        {
            var financialObjectiveEntity = await _financialObjectiveRepository.GetIdAsync(id, cancellationToken);
            return _mapper.Map<FinancialObjectiveDTO>(financialObjectiveEntity);
        }

        public async Task Add(FinancialObjectiveDTO financialObjectiveDTO)
        {
            var financialObjectiveEntity = _mapper.Map<FinancialObjective>(financialObjectiveDTO);
            _financialObjectiveRepository.Create(financialObjectiveEntity);
        }

        public async Task Delete(Guid id, CancellationToken cancellationToken)
        {
            var financialObjectiveEntity = await _financialObjectiveRepository.GetIdAsync(id, cancellationToken);

            if (financialObjectiveEntity != null)
            {
                 _financialObjectiveRepository.Delete(financialObjectiveEntity);
            }
        }

        public async Task Update(FinancialObjectiveDTO financialObjectiveDTO)
        {
            var financialObjectiveEntity = _mapper.Map<FinancialObjective>(financialObjectiveDTO);
             _financialObjectiveRepository.Update(financialObjectiveEntity);
        }
    }
}
