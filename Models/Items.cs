using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsHW.Models
{
    public class Items
    {
        public string ItemName { get; set; }
        public float Weight { get; set; }
        public float Value { get; set; }
        public float Ratio { get; set; }

        public Items()
        {

        }
        public Items(string name, float w, float v)
        {
            ItemName = name;
            Weight = w;
            Value = v;
            Ratio = w / v; // I Hope value is always bigger than weight. I want my ratio between [0, 1].
            //If it is bigger than 1 (weight value is more than price value) than I need to get far far away from that item.
            //If I would have done v/w, since value is generally bigger than weight, I would get ridicilus numbers.
            //Actually it really doesn't matter to me since computer does all the computing. 
        }
    }
}
