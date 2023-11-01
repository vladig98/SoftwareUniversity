namespace Eventures.DbModels
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime OrderedOn { get; set; }
        public string EventuresEventId { get; set; }
        public EventuresEvent EventuresEvent { get; set; }
        public string CustomerId { get; set; }
        public User Customer { get; set; }
        public int TicketsCount { get; set; }

        public override bool Equals(object? obj)
        {
            var order = obj as Order;

            if (order.Id != Id)
            {
                return false;
            }

            if (order.EventuresEventId != EventuresEventId)
            {
                return false;
            }

            if (order.CustomerId != CustomerId)
            {
                return false;
            }

            if (order.TicketsCount != TicketsCount)
            {
                return false;
            }

            if (order.OrderedOn.CompareTo(OrderedOn) != 0)
            {
                return false;
            }

            return true;
        }
    }
}
