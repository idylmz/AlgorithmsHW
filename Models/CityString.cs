using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsHW.Models
{
    public class CityString
    {
        public string RouteList { get; set; }
        public int Distance { get; set; }
        public CityString(string route, int d)
        {
            Distance = d;
            RouteList = route;
        }
    }
}
