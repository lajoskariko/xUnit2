using System;

namespace MyEvents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Event Management System");

            EventManager manager = new EventManager();

            Event codingWorkshop = new Event("Coding Workshop", "Workshop", 30, "Coding Skills", 200);
            Event techTalk = new Event("Tech Talk", "Seminar", 100, "Tech Quiz", 100);

            manager.AddEvent(codingWorkshop);
            manager.AddEvent(techTalk);

            Console.WriteLine("Upcoming Events:");
            DisplayEvent(codingWorkshop);
            DisplayEvent(techTalk);

            Console.WriteLine("\nRegistering 1 attendee for the Coding Workshop...");
            bool registrationResult = codingWorkshop.RegisterAttendee();
            Console.WriteLine($"Registration successful: {registrationResult}");
            DisplayEvent(codingWorkshop);

            Console.WriteLine("\nCancelling the Tech Talk...");
            bool cancellationResult = manager.CancelEvent("Tech Talk");
            Console.WriteLine($"Cancellation successful: {cancellationResult}");
            DisplayEvent(techTalk);

            Console.WriteLine("\nUpdating the prize for the Coding Workshop...");
            codingWorkshop.UpdatePrize(250);
            DisplayEvent(codingWorkshop);

            Console.WriteLine("\nActive Events:");
            foreach (var activeEvent in manager.GetActiveEvents())
            {
                DisplayEvent(activeEvent);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void DisplayEvent(Event evnt)
        {
            Console.WriteLine($"Event: {evnt.Name}, Type: {evnt.Type}, Capacity: {evnt.Capacity}, Active: {evnt.IsActive} Activity Name: {evnt.Activity_Name} Prize: {evnt.Prize}");
        }
    }
}
