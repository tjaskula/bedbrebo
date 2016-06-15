using System;
using System.Runtime.Serialization;

namespace BedBrebo.Domain.Core.Exceptions
{
    public class InvalidIdentifierAssignment : Exception
    {
        public InvalidIdentifierAssignment(string message) : base(message)
        {
        }

        public InvalidIdentifierAssignment(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvalidIdentifierAssignment()
        {
        }

        public InvalidIdentifierAssignment(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}