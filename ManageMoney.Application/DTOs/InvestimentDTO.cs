namespace ManageMoney.Application.DTOs
{
    public class InvestimentDTO
    {
        public Guid Id { get; private set; }
        public string Type { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Date { get; private set; }

        public Guid PerfomanceId { get; private set; }
        public PerfomanceDTO Performance { get; private set; }
    }
}
