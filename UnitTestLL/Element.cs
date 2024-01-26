using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLL
{
    public class Element(Object? data, Element? next)
    {
        public Object? Data { get; set; } = data;
        public Element? Next { get; set; } = next;
    }
}
