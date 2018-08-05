using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class Node
    {
        private Node _Next;

        private object _Values;

        public Node Next { get => _Next; set => _Next = value; }
        public object Values { get => _Values; set => _Values = value; }

        
    }
}
