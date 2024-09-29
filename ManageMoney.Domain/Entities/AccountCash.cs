namespace ManageMoney.Domain.Entities
{
    public class Consumption
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Balance { get; private set; }

        public Guid UserId {  get; private set; }
        public User UserAccount { get; private set; }

        public Consumption(Guid id, string name, decimal balance)
        {
            // Fazer a validação

            Id = id;
            Name = name;
            Balance = balance;
        }

        public Consumption(string name, decimal balance)
        {
            // Fazer a validação

            Name = name;
            Balance = balance;
        }
    }
}
