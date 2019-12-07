using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsHW.Models
{
    public class BonusLList
    {
        public int Multiplier { get; set; }
        public int Base { get; set; }
        public int Power { get; set; }
        public int CalculatedValue { get; set; }
        public BonusLList Next { get; set; }
        public BonusLList(int MultiplierValue, int BaseValue, int PowerValue)
        {
            Multiplier = MultiplierValue;
            Base = BaseValue;
            Power = PowerValue;
            CalculatedValue = MultiplierValue * Convert.ToInt32(Math.Pow(BaseValue,PowerValue));
            Next = null;
        }
        public BonusLList()
        {
            //To construct first node as global.
            Next = null;
        }
    }
}
