namespace ManageMoney.Domain.Entities
{
    public class User
    {
        public Guid Id { get;  set; }
        public string Name { get;  set; }
        public string Email { get;  set; }
        public string Password { get;  set; }
        public DateTime CreateDate { get;  set; }

        public Guid AccountCashId { get;  set; }
        public Consumption Cash { get;  set; }


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
