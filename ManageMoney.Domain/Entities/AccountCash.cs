namespace ManageMoney.Domain.Entities
{
    public class AccountCash
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        // Associado apenas a um User
        public Guid UserId { get; set; }
        public User UserAccount { get; set; }

        public AccountCash(Guid id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public AccountCash(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
