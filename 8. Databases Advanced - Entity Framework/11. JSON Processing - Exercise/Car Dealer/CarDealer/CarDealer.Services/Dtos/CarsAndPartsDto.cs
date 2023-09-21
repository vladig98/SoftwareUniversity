using System.Collections.Generic;

namespace CarDealer.Services.Dtos
{
    public class CarsAndPartsDto
    {
        public CPCarDto car { get; set; }
        public List<PartExportDto> parts { get; set; }
    }
}
