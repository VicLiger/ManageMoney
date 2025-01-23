using System.ComponentModel.DataAnnotations.Schema;

namespace ManageMoney.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }

        // Apenas referência para AccountCash
        [ForeignKey("AccountCash")]
        public Guid AccountCashId { get; set; }
        public AccountCash AccountCash { get; set; }

        public ICollection<Consumption> Consumptions { get; private set; } = new List<Consumption>();
        public FinancialObjective FinancialObjective { get; set; }
        public ICollection<Investiment> Investiments { get; private set; } = new List<Investiment>();

        public User(Guid id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            CreateDate = DateTime.Now;
        }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            CreateDate = DateTime.Now;
        }
    }
}
