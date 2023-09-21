namespace CarDealer.Services.Dtos
{
    public class SalesDiscountsDto
    {
        public CPCarDto car { get; set; }
        public string customerName { get; set; }
        public decimal Discount { get; set; }
        public decimal price { get; set; }
        public decimal priceWithDiscount { get; set; }
    }
}
