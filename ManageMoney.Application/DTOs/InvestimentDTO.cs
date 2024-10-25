namespace ManageMoney.Application.DTOs
{
    public class InvestimentDTO
    {
        public Guid Id { get;  set; }
        public string Type { get;  set; }
        public decimal Value { get;  set; }
        public DateTime Date { get;  set; }

        public Guid PerfomanceId { get;  set; }
        public PerfomanceDTO Performance { get;  set; }
    }
}
