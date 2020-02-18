using System;
using System.Collections.Generic;

namespace PizzaTrade
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public int? IdCustomer { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool Complited { get; set; }
        public DateTime? DateCompl { get; set; }
        public bool Delivery { get; set; }
        public DateTime? DateDelivery { get; set; }
        public bool Payment { get; set; }
        public DateTime? DatePayment { get; set; }
        public int? Status { get; set; }
        public decimal? Amount { get; set; }

        public virtual Customers IdCustomerNavigation { get; set; }
        public virtual Status StatusNavigation { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
