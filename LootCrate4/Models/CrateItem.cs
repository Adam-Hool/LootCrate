using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootCrate4.Models
{
    public class CrateItem
    {
        public int ID { get; set; }
        public Toy toy { get; set; }
        public VideoGame videoGame { get; set; }
        public Shirt shirt { get; set; }
        public BobbleHead bobbleHead { get; set; }
    }
}