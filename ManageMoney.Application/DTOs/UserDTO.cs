namespace ManageMoney.Application.DTOs
{
    public class UserDTO
    {
        public Guid Id { get;  set; }
        public string Name { get;  set; }
        public string Email { get;  set; }
        public string Password { get;  set; }
        public DateTime CreateDate { get;  set; }

        public Guid AccountCashId { get;  set; }
        public ConsumptionDTO Cash { get;  set; }

        public UserDTO() { }
    }
}
