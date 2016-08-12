using System;
using System.Collections.Generic;
using BedBrebo.Domain.Bookings.Commands;
using BedBrebo.Domain.Bookings.Events;
using BedBrebo.Domain.Core;

namespace BedBrebo.Domain.Bookings
{
    public class LodgingAvailability : IEventPublisher
    {
        private readonly IList<IEvent> _changes = new List<IEvent>();
      
        public LodgingAvailability(LodgingId lodgingId)
        {
            if (lodgingId == null) throw new ArgumentNullException(nameof(lodgingId));

            Id = lodgingId;
        }

        public LodgingId Id { get; private set; }

        public void BookLodging(PutInBookingRequest command)
        {
            _changes.Add(new LodgingBooked());
        }

        public IEnumerable<IEvent> GetChanges()
        {
            return _changes;
        }
    }
}