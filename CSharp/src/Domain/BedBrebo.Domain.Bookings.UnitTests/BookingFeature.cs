using System.Linq;
using BedBrebo.Domain.Bookings.Commands;
using BedBrebo.Domain.Bookings.Events;
using BedBrebo.Domain.Core;
using Xbehave;
using FluentAssertions;

namespace BedBrebo.Domain.Bookings.UnitTests
{
    public class BookingFeature
    {
        [Scenario]
        public void ConfirmBookingOnAvailableLodging(LodgingAvailability lodgingAvailability, PutInBookingRequest command, IEvent @event)
        {
            var lodgingId = new LodgingId(343);

            "Given LodgingAvailability ID 343 from 1 to 7 June."
                .x(() => lodgingAvailability = new LodgingAvailability(lodgingId));

            "And booking request for Lodging ID 343"
                .x(() => command = new PutInBookingRequest(lodgingId));

            "When a Guest is making a booking request for Lodging ID 343"
                .x(() =>
                {
                    lodgingAvailability.Handle(command);
                    @event = lodgingAvailability.GetChanges().First();
                });

            "Then Lodging booking is confirmed"
                .x(() => @event.Should().BeOfType<LodgingBooked>());
        }
    }
}