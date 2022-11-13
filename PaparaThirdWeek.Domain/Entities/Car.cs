﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PaparaThirdWeek.Domain.Entities
{
    public class Car : BaseEntity
    {
        public int BrandId { get; set; }

        public int ColorId { get; set; }

        public int ModelYear { get; set; }

        public int DailyPrice { get; set; }

        public string Description { get; set; }
    }
}
