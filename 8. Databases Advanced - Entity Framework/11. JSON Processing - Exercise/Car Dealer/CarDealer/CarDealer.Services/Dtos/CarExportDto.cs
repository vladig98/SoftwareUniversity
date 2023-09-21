namespace CarDealer.Services.Dtos
{
    public class CarExportDto
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public ulong TravelledDistance { get; set; }
    }
}
