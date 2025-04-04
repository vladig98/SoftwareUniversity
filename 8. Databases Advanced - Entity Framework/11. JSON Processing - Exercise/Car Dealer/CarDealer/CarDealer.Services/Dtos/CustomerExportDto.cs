﻿using CarDealer.Models;
using System;
using System.Collections.Generic;

namespace CarDealer.Services.Dtos
{
    public class CustomerExportDto
    {
        public CustomerExportDto()
        {
            Sales = new List<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsYoungDriver { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
