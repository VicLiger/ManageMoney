namespace ManageMoney.Application.DTOs
{
    public class FinancialObjectiveDTO
    {
        public Guid Id { get;  set; }
        public decimal Value { get;  set; }
        public DateTime Date { get;  set; }
        public string Type { get;  set; }
    }
}
