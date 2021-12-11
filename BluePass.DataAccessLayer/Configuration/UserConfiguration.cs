using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BluePass.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BluePass.DataAccessLayer.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.UserName).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(45).IsRequired();
            builder.Property(p => p.SurName).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Pin).HasMaxLength(45).IsRequired();
            builder.Property(p => p.UserId).IsRequired();

        }
    }
}
