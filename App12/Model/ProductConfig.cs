using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace app07.Model
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Mahsol", "forosh");
            builder.Property(x => x.Description)
                    .HasMaxLength(200)
                    .IsRequired()
                    .IsUnicode(false)
                    ;
            builder.Property(x => x.Name)
                    .HasMaxLength(100)
                    .IsRequired()
                    .IsUnicode(true)
                    ;
        }
    }
}
