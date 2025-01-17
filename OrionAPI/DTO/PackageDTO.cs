﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrionAPI.DTO
{
    public class PackageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
    }
}
