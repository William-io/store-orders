using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities;

namespace Store.Infra.Settings
{
    public class ItemSettings : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnType("varchar(150)").IsRequired();
            builder.Property(x => x.Price).HasPrecision(18, 2);



        //     builder.HasData(
        //        new Item("Calça Black Jeans Masculina Slim Preto Pool", 89.90m),
        //        new Item("Bermuda Jeans Masculina Slim Elástico Denim Escuro Pool", 85.90m),
        //        new Item("Camiseta Plus Size Masculina Manga Curta Minimalista Branco", 56.90m)
        //    );
        }
    }
}
