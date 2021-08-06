using System.Collections.Generic;

namespace Store.Domain.Entities
{
    public sealed class Customer : Entity
    {
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
            this.Orders = new HashSet<Order>();
        }

        public string Name { get; private set; }
        public ICollection<Order> Orders { get; set; }

        //ValidateDomain criar uma validação caso seja necessario 
    }

}