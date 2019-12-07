using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsHW.Models
{
    /*
     * This is my common model for linked list operations. Since I am not allowed to use stacks nor queues,
     * I will operate with linked lists. I might be a little rusty since this is the subject of Data Structures
     * and it has been 2 years(not 1 year, "2 years") since I took that class.
    */
    public class MyLList
    {
        public Node First;
        public Node Last;
        public class Node
        {
            public Node() //When I am constructing without Data property.
            {
                Next = null;
                Previous = null;
            }
            public Node(int d) //To reduce lines, when I have a data, I will construct my class as this in my code.
            {
                Data = d;
                Next = null;
                Previous = null;
            }
            /*
             * Yes, this might seem similar to
             * the one on the web. But seriously,
             * this is my code.
            */
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
        }
    }
}
