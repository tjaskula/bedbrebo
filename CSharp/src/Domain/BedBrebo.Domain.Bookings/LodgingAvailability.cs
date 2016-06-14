using System;

namespace BedBrebo.Domain.Bookings
{
    public class LodgingAvailability
    {
        public LodgingAvailability(LodgingId lodgingId)
        {
            if (lodgingId == null) throw new ArgumentNullException(nameof(lodgingId));

            Id = lodgingId;
        }

        public LodgingId Id { get; private set; }
    }
}