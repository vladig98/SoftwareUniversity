using System;

namespace CarDealer.Services.Dtos
{
    public class CustomerDto
    {
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public bool isYoungDriver { get; set; }
    }
}
