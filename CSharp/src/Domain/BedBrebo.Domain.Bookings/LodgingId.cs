using BedBrebo.Domain.Core;
using BedBrebo.Domain.Core.Exceptions;

namespace BedBrebo.Domain.Bookings
{
    public class LodgingId : IIdentifier<int>
    {
        private readonly int _id;

        public LodgingId(int id)
        {
            if (id <= 0) throw new InvalidIdentifierAssignment($"The id value '{id}' must be greater then 0.");

            _id = id;
        }

        public int GetId()
        {
            return _id;
        }
    }
}