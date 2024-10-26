using ManageMoney.Domain.Entities;

namespace ManageMoney.Application.DTOs
{
    public class AccountCashDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public Guid UserId { get; set; }
        public User UserAccount { get; set; }

        public AccountCashDTO() { }
    }
}
