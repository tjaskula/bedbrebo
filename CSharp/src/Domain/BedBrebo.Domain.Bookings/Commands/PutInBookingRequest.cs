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

            Id = id;
        }

        public LodgingId Id { get; private set; }
    }
}