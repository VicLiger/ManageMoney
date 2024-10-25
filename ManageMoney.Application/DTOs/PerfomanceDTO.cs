
namespace ManageMoney.Application.DTOs
{
    public class PerfomanceDTO
    {
        public Guid Id { get;  set; }
        public decimal Value { get;  set; }
        public DateTime Date { get;  set; }
        public string Type { get;  set; }

        // Relações
        public Guid InvestimentId { get;  set; }
        public InvestimentDTO Investiment { get;  set; }
    }
}
