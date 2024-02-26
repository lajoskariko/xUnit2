using Xunit;
using MyEvents;

namespace MyEvents.Tests
{
    public class EventTests
    {
        [Fact]
        public void Event_IsActive_WhenCreated()
        {
            var evnt = new Event("Code Workshop", "Workshop", 50, "Coding race", 200);
            Assert.True(evnt.IsActive);
        }

        [Fact]
        public void CancelEvent_SetsIsActiveToFalse()
        {
            var evnt = new Event("Code Workshop", "Workshop", 50, "Coding race", 200);
            evnt.Cancel();
            Assert.False(evnt.IsActive);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(1)]
        public void RegisterAttendee_DecreasesCapacity(int initialCapacity)
        {
            var evnt = new Event("Code Workshop", "Workshop", initialCapacity, "Coding race", 200);
            bool registrationResult = evnt.RegisterAttendee();

            Assert.True(registrationResult);
            Assert.Equal(initialCapacity - 1, evnt.Capacity);
        }

        [Fact]
        public void RegisterAttendee_ReturnsFalse_WhenEventIsFull()
        {
            var evnt = new Event("Code Workshop", "Workshop", 0, "Coding race", 200); // Event is already full
            bool registrationResult = evnt.RegisterAttendee();
            Assert.False(registrationResult);
        }

        [Fact]
        public void UpdatePrize_UpdatesPrizeWhenEventIsActive()
        {
            var evnt = new Event("Code Workshop", "Workshop", 50, "Coding", 100);

            evnt.UpdatePrize(150);

            Assert.Equal(150, evnt.Prize);
        }

        [Fact]
        public void UpdatePrize_DoesNotUpdatePrizeWhenEventIsInactive()
        {
            var evnt = new Event("Code Workshop", "Workshop", 50, "Coding", 100);
            evnt.Cancel();

            evnt.UpdatePrize(150);

            Assert.Equal(100, evnt.Prize); 
        }
    }
}