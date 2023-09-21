namespace ProductShop.Services.Dtos
{
    public class UPUsersDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int? age { get; set; }
        public SoldProductsDto soldProducts { get; set; }
    }
}
