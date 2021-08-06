using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities;

namespace Store.Infra.Settings
{
    public class CustomerSettings : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnType("varchar(120)").HasDefaultValue(null).IsRequired();


            builder.HasData(
                new Customer(1,"William Silva"),
                new Customer(2,"John Doe"),
                new Customer(3,"Otto Victor"),
                new Customer(4,"Débora"),
                new Customer(5,"Júlia"),
                new Customer(6,"Doe Jo")
            );
        }
    }
}
