namespace BusarovsQuickBite.Core.Exceptions
{
    public class ApplicationException : Exception
    {
        public ApplicationException() { }
        public ApplicationException(string message) : base(message) { }
    }
}
