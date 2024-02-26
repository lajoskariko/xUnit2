namespace MyEvents
{
    public class Event
    {
        public string Name { get; }
        public string Type { get; }
        public int Capacity { get; private set; }
        public bool IsActive { get; private set; }
        public string Activity_Name { get; }
        public int Prize { get; private set; }

        public Event(string name, string type, int capacity, string activity, int prize)
        {
            Name = name;
            Type = type;
            Capacity = capacity;
            IsActive = true;
            Activity_Name = activity;
            Prize = prize;
        }

        public void Cancel()
        {
            IsActive = false;
        }

        public bool RegisterAttendee()
        {
            if (IsActive && Capacity > 0)
            {
                Capacity--;
                return true;
            }
            return false;
        }

        public void UpdatePrize(int newPrize)
        {
            if (IsActive)
            {
                Prize = newPrize;
            }
        }
    }
}