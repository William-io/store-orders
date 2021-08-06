using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities;

namespace Store.Infra.Settings
{
    public class OrderSettings : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasConversion<long>().HasColumnType("bigint"); //Convert de int para long numa coluna bigint
            

            builder.Property(x => x.OrderNo).HasColumnType("varchar(50)"); //Tipo varchar / Allow Nulls
            builder.Property(x => x.PaymentMethod).HasColumnType("varchar(50)");
            builder.Property(x => x.GrandTotal).HasPrecision(18, 2);


        }
    }
}


