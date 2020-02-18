using System;
using System.Collections.Generic;

namespace PizzaTrade
{
    public partial class OrderDetails
    {
        public int IdOrder { get; set; }
        public int IdPizza { get; set; }
        public decimal? Price { get; set; }
        public short? Count { get; set; }

        public virtual Orders IdOrderNavigation { get; set; }
        public virtual Pizzas IdPizzaNavigation { get; set; }
    }
}
