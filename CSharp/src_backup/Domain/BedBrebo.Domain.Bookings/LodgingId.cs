using BedBrebo.Domain.Core;
using BedBrebo.Domain.Core.Exceptions;

namespace BedBrebo.Domain.Bookings
{
    public class LodgingId : ValueObject<LodgingId>, IIdentifier<int>
    {
        public LodgingId(int id)
        {
            if (id <= 0) throw new InvalidIdentifierAssignmentException($"The id value '{id}' must be greater then 0.");

            Id = id;
        }

        public int Id { get; private set; }
    }
}