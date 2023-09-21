using System.Collections.Generic;

namespace ProductShop.Services.Dtos
{
    public class SoldProductsDto
    {
        public SoldProductsDto()
        {
            products = new List<ProductDto>();
        }

        public int count { get; set; }
        public List<ProductDto> products { get; set; }
    }
}
