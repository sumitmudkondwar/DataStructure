﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Node Next;
        public object Value;
    }

    public class Node<T>
    {
        public Node<T> Next;
        public object Value;
    }
}
