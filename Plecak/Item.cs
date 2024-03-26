using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class Item
    {
        public Item(int id, int v, int w) {
            Id = id;
            value = v;
            weight = w;
        }
        public int Id { get; set; }
        public int value { get; set; }
        public int weight {  get; set; }
        public override string ToString() {
            return "no.: " + Id + "\tv: " + value + "\tw: " + weight;
        }
    }
}
