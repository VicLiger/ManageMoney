
namespace ManageMoney.Application.DTOs
{
    public class AccountCashDTO
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Balance { get; private set; }

        public Guid UserId { get; private set; }
        public UserDTO UserAccount { get; private set; }
    }
}
