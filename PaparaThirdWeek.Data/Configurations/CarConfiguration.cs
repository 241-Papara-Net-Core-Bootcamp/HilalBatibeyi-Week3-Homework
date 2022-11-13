using Microsoft.EntityFrameworkCore;
using PaparaThirdWeek.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaThirdWeek.Data.Configurations
{
    // productı tablo yapar
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.CarId);
            builder.Property(x => x.BrandId).IsRequired();
            builder.Property(x => x.ColorId).IsRequired();
            builder.ToTable("Cars");
        }
    }
}
