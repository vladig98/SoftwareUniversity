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
    }
}
