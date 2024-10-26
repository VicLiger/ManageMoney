using ManageMoney.Domain.Entities;

namespace ManageMoney.Application.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }

        public Guid AccountCashId { get; set; }
        public AccountCash AccountCash { get; set; }

        public ICollection<Consumption> Consumptions { get; private set; } = new List<Consumption>();

        public FinancialObjective FinancialObjective { get; set; }

        public ICollection<Investiment> Investiments { get; private set; } = new List<Investiment>();
    }
}
