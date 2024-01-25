using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLL
{
    public class Element
    {
        public Object Data;
        public Element Next;

        public Element()
        {
            
        }
        public Element(Object data, Element next)
        {
            Data = data;
            Next = next;
        }
    }
}
