using Xbehave;
using Xunit;

namespace BedBrebo.Domain.Bookings.UnitTests
{
    public class BookingFeature
    {
        [Scenario]
        public void ConfirmBookingOnAvailableLodging(LodgingAvailability lodgingAvailability)
        {
            "Given LodgingAvailability ID 343"
                .x(() => lodgingAvailability = new LodgingAvailability(new LodgingId(343)));

            //"And the number 2"
            //    .x(() => y = 2);

            //"And a calculator"
            //    .x(() => calculator = new Calculator());

            //"When I add the numbers together"
            //    .x(() => answer = calculator.Add(x, y));

            "Then the answer is 3"
                .x(() => Assert.Equal(3, 3));
        }
    }
}