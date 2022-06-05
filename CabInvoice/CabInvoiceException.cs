using System.Runtime.Serialization;

namespace CabInvoice
{
    [Serializable]
    internal class CabInvoiceException : Exception
    {
        internal static readonly object ExceptionType;

        public CabInvoiceException()
        {
        }

        public CabInvoiceException(string? message) : base(message)
        {
        }

        public CabInvoiceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CabInvoiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}