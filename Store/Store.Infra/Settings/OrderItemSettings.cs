using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities;

namespace Store.Infra.Settings
{
    public class OrderItemSettings : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasConversion<long>().HasColumnType("bigint");

            // builder.Property(x => x.Order);
            // builder.Property(x => x.Item);
            builder.Property(x => x.Quantity);


        }
    }
}