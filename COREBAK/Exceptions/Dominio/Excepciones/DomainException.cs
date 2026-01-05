namespace COREBAK.Exceptions.Dominio.Excepciones
{
    public abstract class DomainException : Exception
    {
        public DomainException(string message) : base(message) { }
    }

    public class ValidationException : DomainException
    {
        public ValidationException(string message) : base(message) { }
    }

    public class NotFoundException : DomainException
    {
        public NotFoundException(string message) : base(message) { }
    }

    public class BusinessRuleException : DomainException
    {
        public BusinessRuleException(string message) : base(message) { }
    }
}