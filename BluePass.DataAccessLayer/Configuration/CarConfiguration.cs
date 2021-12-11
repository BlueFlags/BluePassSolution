using BluePass.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePass.DataAccessLayer.Configuration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Plate).HasMaxLength(45).IsRequired();
            builder.Property(p => p.UserId).IsRequired();

            builder.HasOne(p => p.UserFK)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(p => p.UserId);
        }

    }
}
