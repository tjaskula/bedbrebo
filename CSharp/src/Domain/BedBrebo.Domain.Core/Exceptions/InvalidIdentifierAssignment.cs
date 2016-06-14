using System;

namespace BedBrebo.Domain.Core.Exceptions
{
    public class InvalidIdentifierAssignment : Exception
    {
        public InvalidIdentifierAssignment(string message) : base(message)
        {
        }
    }
}