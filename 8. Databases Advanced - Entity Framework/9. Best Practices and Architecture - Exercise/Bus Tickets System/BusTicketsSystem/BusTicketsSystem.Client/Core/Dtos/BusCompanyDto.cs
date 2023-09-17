using System.Collections.Generic;

namespace BusTicketsSystem.Client.Core.Dtos
{
    public class BusCompanyDto
    {
        public BusCompanyDto()
        {
            Reviews = new List<ReviewDto>();
        }

        public int Id { get; set; }
        public ICollection<ReviewDto> Reviews { get; set; }
    }
}
