
namespace ManageMoney.Application.DTOs
{
    public class ConsumptionDTO
    {
        public Guid Id { get;  set; }
        public decimal Value { get;  set; }
        public string Category { get;  set; }
        public DateTime Date { get;  set; }
        public string Description { get;  set; }
    }
}
