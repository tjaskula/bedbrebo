using System;
using System.Runtime.Serialization;

namespace BedBrebo.Domain.Core.Exceptions
{
    public class InvalidIdentifierAssignmentException : Exception
    {
        public InvalidIdentifierAssignmentException(string message) : base(message)
        {
        }

        public InvalidIdentifierAssignmentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvalidIdentifierAssignmentException()
        {
        }

        public InvalidIdentifierAssignmentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}