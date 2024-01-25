using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLL
{
    public class LinkedList
    {
        public Element _baseElement;
        public void Add_First(object _newData)
        {
            Element _newElement = new(_newData, _baseElement);
            _baseElement = _newElement;
        }

        public void Remove_First()
        {
            _baseElement = _baseElement.Next;
        }

        public int Count()
        {
            if (_baseElement == null)
            {
                return 0;
            }
            else
            {
                int _counter = 0;
                Element _tempElement = _baseElement;

                while (_tempElement.Next != null)
                {
                    _counter++;

                    if (_tempElement.Next != null)
                    {
                        _tempElement = _tempElement.Next;
                    }
                }

                return ++_counter;
            }
        }

        public string To_String()
        {
            string _resultString = "";
            if (_baseElement == null)
            {
                return "Empty.";
            }
            else
            {
                Element _tempElement = _baseElement;
                while (_tempElement != null)
                {
                    _resultString += _tempElement.Data.ToString() + ", ";
                    _tempElement = _tempElement.Next;
                }
            }

            return _resultString;
        }

        public void Sort()
        {
            Element _swapElement = _baseElement;
            int _position;

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
