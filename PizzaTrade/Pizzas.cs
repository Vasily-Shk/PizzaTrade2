using System;
using System.Collections.Generic;

namespace PizzaTrade
{
    public partial class Pizzas
    {
        public Pizzas()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public string PizzaName { get; set; }
        public string Description { get; set; }
        public byte Diameter { get; set; }
        public short Weight { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
