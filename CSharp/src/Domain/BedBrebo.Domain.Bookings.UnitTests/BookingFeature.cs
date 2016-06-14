using Xbehave;
using Xunit;

namespace BedBrebo.Domain.Bookings.UnitTests
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    public class BookingFeature
    {
        [Scenario]
        public void BookingConfirmation(int x, int y, Calculator calculator, int answer)
        {
            "Given the number 1"
                .x(() => x = 1);

            "And the number 2"
                .x(() => y = 2);

            "And a calculator"
                .x(() => calculator = new Calculator());

            "When I add the numbers together"
                .x(() => answer = calculator.Add(x, y));

            "Then the answer is 3"
                .x(() => Assert.Equal(3, answer));
        }
    }
}