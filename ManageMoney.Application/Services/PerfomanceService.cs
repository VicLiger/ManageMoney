using AutoMapper;
using ManageMoney.Application.DTOs;
using ManageMoney.Application.Interfaces;
using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;


namespace ManageMoney.Application.Services
{
    public class PerformanceService : IPerfomanceService
    {
        private readonly IPerfomanceRepository _performanceRepository;
        private readonly IMapper _mapper;

        public PerformanceService(IPerfomanceRepository performanceRepository, IMapper mapper)
        {
            _performanceRepository = performanceRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PerfomanceDTO>> GetPerfomances(CancellationToken cancellationToken)
        {
            var performanceEntities = await _performanceRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<PerfomanceDTO>>(performanceEntities);
        }

        public async Task<PerfomanceDTO> GetPerfomance(Guid id, CancellationToken cancellationToken)
        {
            var performanceEntity = await _performanceRepository.GetIdAsync(id, cancellationToken);
            return _mapper.Map<PerfomanceDTO>(performanceEntity);
        }

        public async Task Add(PerfomanceDTO perfomanceDTO)
        {
            var performanceEntity = _mapper.Map<Performance>(perfomanceDTO);
             _performanceRepository.Create(performanceEntity);
        }

        public async Task Delete(Guid id, CancellationToken cancellationToken)
        {
            var performanceEntity = await _performanceRepository.GetIdAsync(id, cancellationToken);

            if (performanceEntity != null)
            {
                 _performanceRepository.Delete(performanceEntity);
            }
        }

        public async Task Update(PerfomanceDTO perfomanceDTO)
        {
            var performanceEntity = _mapper.Map<Performance>(perfomanceDTO);
             _performanceRepository.Update(performanceEntity);
        }
    }
}
