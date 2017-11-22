using BedBrebo.Domain.Bookings.Commands;
using BedBrebo.Domain.Core;

namespace BedBrebo.Domain.Bookings.CommandHandlers
{
    public class BookingCommandHandler : ICommandHandler
    {
        public void PutInBookingRequest(PutInBookingRequest command)
        {
            var lodgingAvailability = new LodgingAvailability(new LodgingId(1));
            lodgingAvailability.BookLodging(command);
        }
    }
}