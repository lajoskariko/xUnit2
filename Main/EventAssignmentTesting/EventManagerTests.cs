using Xunit;
using MyEvents;

namespace MyEvents.Tests
{
    public class EventManagerTests
    {
        [Fact]
        public void AddEvent_IncreasesEventsCount()
        {
            var manager = new EventManager();
            var evnt = new Event("Networking Event", "Meetup", 100, "Binary Party", 0);
            manager.AddEvent(evnt);

            Assert.NotNull(manager.GetEvent("Networking Event"));
        }

        [Fact]
        public void CancelEvent_MakesEventInactive()
        {
            var manager = new EventManager();
            var evnt = new Event("Networking Event", "Meetup", 100, "Binary Party", 0);
            manager.AddEvent(evnt);
            manager.CancelEvent("Networking Event");

            Assert.False(manager.GetEvent("Networking Event").IsActive);
        }

        [Fact]
        public void GetActiveEvents_ReturnsOnlyActiveEvents()
        {
            var manager = new EventManager();
            var activeEvent = new Event("Active Event", "Workshop", 50, "Activity", 50);
            var inactiveEvent = new Event("Inactive Event", "Conference", 100, "Activity", 50);
            inactiveEvent.Cancel();
            manager.AddEvent(activeEvent);
            manager.AddEvent(inactiveEvent);

            var activeEvents = manager.GetActiveEvents();

            Assert.Single(activeEvents);
            Assert.Contains(activeEvent, activeEvents);
            Assert.DoesNotContain(inactiveEvent, activeEvents);
        }
    }
}