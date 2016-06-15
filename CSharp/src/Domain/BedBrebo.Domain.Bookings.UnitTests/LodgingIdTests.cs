using BedBrebo.Domain.Core.Exceptions;
using Xunit;

namespace BedBrebo.Domain.Bookings.UnitTests
{
    public class LodgingIdTests
    {
        [Theory,
        InlineData(-10),
        InlineData(-1),
        InlineData(0)]
        public void Should_throw_on_construction_for_invalid_id(int id)
        {
            Assert.Throws<InvalidIdentifierAssignment>(() => new LodgingId(id));
        }

        [Theory,
        InlineData(1),
        InlineData(10),
        InlineData(999)]
        public void Should_not_throw_on_construction_for_valid_id(int id)
        {
            var lodgingId = new LodgingId(id);
            Assert.Equal(id, lodgingId.Id);
        }
    }
}