namespace ManageMoney.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime CreateDate { get; private set; }

        public Guid AccountCashId { get; private set; }
        public Consumption Cash { get; private set; }


        public User(Guid id, string name, string email, string password)
        {

            // Implementar a validação dos dados

            Id = id;
            Name = name;    
            Email = email;
            Password = password;
            CreateDate = DateTime.Now;
        }

        public User(string name, string email, string password)
        {

            // Implementar a validação dos dados

            Name = name;
            Email = email;
            Password = password;
            CreateDate = DateTime.Now;

        }
    }
}
