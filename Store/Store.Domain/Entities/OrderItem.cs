namespace Store.Domain.Entities
{
    public sealed class OrderItem : Entity
    {
        //OrderItemId é do tipo bigint
        
        //public int OrderId { get; set; }
        //public int ItemId { get; set; }
        public int Quantity { get; private set; }

        public  Item Item { get;  set; }
        public  Order Order { get;  set; }

        

    }
    
}