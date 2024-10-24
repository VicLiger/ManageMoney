namespace ManageMoney.Domain.Validations
{
    public class DomainValidationException : Exception
    {
        public DomainValidationException(string error) : base(error) 
        {
            
        }


    }
}
