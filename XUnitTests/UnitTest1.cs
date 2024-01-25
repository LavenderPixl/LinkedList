using System.Linq.Expressions;
using UnitTestLL;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddFirst()
        {
            Element _firstElement = new();
            Element _secondElement = new(23, new Element());
            _firstElement.Next = _secondElement;

            Element _newElement = new(1263, new Element());
            _newElement.Next = _secondElement;
            _firstElement.Next = _newElement;

            Assert.True(_firstElement.Next == _newElement);
            Assert.True(_newElement.Next == _secondElement);
        }
    }
}