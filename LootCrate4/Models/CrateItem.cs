using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootCrate4.Models
{
    public class CrateItem
    {
        public int ID { get; set; }
        public virtual Toy toy { get; set; }
        public virtual VideoGame videoGame { get; set; }
        public virtual Shirt shirt { get; set; }
        public virtual BobbleHead bobbleHead { get; set; }

    }
}