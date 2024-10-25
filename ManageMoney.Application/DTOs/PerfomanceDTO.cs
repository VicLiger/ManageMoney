
namespace ManageMoney.Application.DTOs
{
    public class PerfomanceDTO
    {
        public Guid Id { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Date { get; private set; }
        public string Type { get; private set; }

        // Relações
        public Guid InvestimentId { get; private set; }
        public InvestimentDTO Investiment { get; private set; }
    }
}
