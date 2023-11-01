namespace Eventures.DbModels
{
    public class EventuresEvent
    {
        public EventuresEvent()
        {
            Orders = new HashSet<Order>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int TotalTickets { get; set; }
        public decimal PricePerTicket { get; set; }
        public ICollection<Order> Orders { get; set; }

        public override bool Equals(object? obj)
        {
            var eventuresEvent = obj as EventuresEvent;

            if (eventuresEvent.Id != Id)
            {
                return false;
            }

            if (eventuresEvent.Name != Name)
            {
                return false;
            }

            if (eventuresEvent.Place != Place)
            {
                return false;
            }

            if (eventuresEvent.Start.CompareTo(Start) != 0)
            {
                return false;
            }

            if (eventuresEvent.End.CompareTo(End) != 0)
            {
                return false;
            }

            if (eventuresEvent.TotalTickets != TotalTickets)
            {
                return false;
            }

            if (eventuresEvent.PricePerTicket != PricePerTicket)
            {
                return false;
            }

            return true;
        }
    }
}
