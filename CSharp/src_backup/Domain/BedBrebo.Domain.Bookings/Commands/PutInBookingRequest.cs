using System;
using BedBrebo.Domain.Core;

namespace BedBrebo.Domain.Bookings.Commands
{
    public class PutInBookingRequest : ICommand
    {
        public PutInBookingRequest(LodgingId id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            LoggingId = id;
            Id = Guid.NewGuid();
        }

        public LodgingId LoggingId { get; private set; }
        public Guid Id { get; }
    }
}