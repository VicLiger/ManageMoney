namespace ManageMoney.Application.DTOs
{
    public class AccountCashDTO
    {
        public Guid Id { get; set; }  // Alterar para set; para permitir a deserialização
        public string Name { get; set; }  // Alterar para set;
        public decimal Balance { get; set; }  // Alterar para set;

        public Guid UserId { get; set; }  // Alterar para set;
        public UserDTO UserAccount { get; set; }  // Alterar para set;

        // Construtor padrão (opcional, se você não precisar de lógica de inicialização)
        public AccountCashDTO() { }
    }
}
