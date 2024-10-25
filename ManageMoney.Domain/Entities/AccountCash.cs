namespace ManageMoney.Domain.Entities
{
    public class AccountCash
    {
        public Guid Id { get;  set; }
        public string Name { get;  set; }
        public decimal Balance { get;  set; }

        public Guid UserId {  get;  set; }
        public User UserAccount { get;  set; }

        public AccountCash(Guid id, string name, decimal balance)
        {
            // Fazer a validação

            Id = id;
            Name = name;
            Balance = balance;
        }

        public AccountCash(string name, decimal balance)
        {
            // Fazer a validação

            Name = name;
            Balance = balance;
        }
    }
}
