using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLL
{
    public class LinkedList
    {
        Element _baseElement = new(0, null);
        public void Add_First(Element _first, Element _newElement)
        {
            _newElement.Next = _first.Next;
            _first.Next = _newElement;
            Console.WriteLine(_first.Data.ToString(), _newElement.Data.ToString());
        }

        public void Remove_First(Element _baseElement, Element _firstElement)
        {
            _baseElement.Next = _firstElement.Next;
        }

        public int Count(Element _startElement)
        {

            int _counter = 1;
            do
            {
                _startElement = _startElement.Next;
                _counter++;
            } while (_startElement.Next != null);

            return _counter;
        }

        public string To_String(Element _startElement)
        {
            string _resultString = "";

            while (_startElement != null)
            {
                _resultString += _startElement.Data.ToString() + ", ";
                Console.Write(_startElement.Data + ", ");
                _startElement = _startElement.Next;
            }

            return _resultString;
        }

        public void Sort(Element _startElement)
        {

            Element _swapElement = _startElement;
            int _position;
            //string _resultString = "Error! Help. ";

            while (_swapElement != null)
            {
                if (_swapElement.Next != null)
                {
                    if (Convert.ToInt32(_swapElement.Data) > Convert.ToInt32(_swapElement.Next.Data))
                    {
                        (_swapElement.Data, _swapElement.Next.Data) = (_swapElement.Next.Data, _swapElement.Data);
                    }
                }
                _swapElement = _swapElement.Next;
            }
            //return _resultString;
        }
    }
}
