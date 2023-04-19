using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ListManager
{
    public class Node
    {

        public int Value { get; set; }
        public Node? Next { get; set; }

        public Node? Prev { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
}
