using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using UnitTestLL;

namespace XUnitTests
{
    public class UnitTest1
    {
        LinkedList LL = new();
        [Fact]
        public void AddFirst()
        {
            Element _startElement = new(0, null);
            Element _secondElement = new(521, null);
            Element _thirdElement = new(3, null);
            _startElement.Next = _secondElement;
            _secondElement.Next = _thirdElement;

            Element _newElement = new(2501, null);


            LL.Add_First(_startElement, _newElement);

            Assert.True(_startElement.Next == _newElement);
            Assert.True(_newElement.Next == _secondElement);
        }

        [Fact]
        public void RemoveFirst()
        {
            //Three Elements added.
            Element _startElement = new(0, null);
            Element _firstElement = new(23, null);
            Element _secondElement = new(212, null);
            _startElement.Next = _firstElement;
            _firstElement.Next = _secondElement;

            //Remove test.
            LL.Remove_First(_startElement, _firstElement);

            Assert.True(_startElement.Next == _secondElement);
        }

        [Fact]
        public void Count()
        {
            Element _startElement = new(0, null);
            Element _firstElement = new(23, null);
            Element _secondElement = new(212, null);
            _startElement.Next = _firstElement;
            _firstElement.Next = _secondElement;

            int _counter = LL.Count(_startElement);

            Assert.Equal(3, _counter);
        }

        [Fact]
        public void To_String()
        {
            Element _startElement = new(0, null);
            Element _firstElement = new(23, null);
            Element _secondElement = new(212, null);
            _startElement.Next = _firstElement;
            _firstElement.Next = _secondElement;

            string _result = LL.To_String(_startElement);

            Assert.Equal("0, 23, 212, ", _result);
        }

        [Fact]
        public void Sort()
        {
            Element _startElement = new(0, null);
            Element _firstElement = new(23111, null);
            Element _secondElement = new(212, null);
            _startElement.Next = _firstElement;
            _firstElement.Next = _secondElement;

            LL.Sort(_startElement);
            string _sortedList = LL.To_String(_startElement);
            Assert.Equal("0, 212, 23111, ", _sortedList);
        }
    }
}