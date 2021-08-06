using System.Collections.Generic;

namespace Store.Domain.Entities
{
    public sealed class Item : Entity
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
            this.OrderItems = new HashSet<OrderItem>();
        }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public ICollection<OrderItem> OrderItems { get; set; }

    }

}