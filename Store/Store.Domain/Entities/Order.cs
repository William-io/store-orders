using System;
using System.Collections.Generic;

namespace Store.Domain.Entities
{
    //OrderId é do tipo bigint
    public sealed class Order : Entity
    {
        public Order()
        {
            
            //DeletedOrderItemIDs = deletedOrderItemIDs;
            this.OrderItems = new HashSet<OrderItem>();
            OrderNo = Guid.NewGuid().ToString().Substring(0, 8); //--*
        }

        public string OrderNo { get; private set; }
        //public Nullable<int> CustomerId { get; set; }
        public string PaymentMethod { get; private set; }
        public decimal GrandTotal { get; private set; }

        // [NotMapped]
        // public string DeletedOrderItemIDs { get; set; }

        public Customer Customer { get;  set; }
        public ICollection<OrderItem> OrderItems { get;  set; }


        
            
    }

}