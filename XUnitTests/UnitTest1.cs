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
            LL.Add_First(2501);

            Assert.Equal(2501, Convert.ToInt32(LL._baseElement.Data));
        }

        [Fact]
        public void RemoveFirst()
        {
            LL.Add_First(231);
            LL.Add_First(1);

            //Remove test.
            LL.Remove_First();

            Assert.Equal(231, Convert.ToInt32(LL._baseElement.Data));
        }

        [Fact]
        public void Count()
        {
            LL.Add_First(31);
            LL.Add_First(31);
            LL.Add_First(31);
            int _counter = LL.Count();

            Assert.Equal(3, _counter);
        }
        [Fact]
        public void CountEmpty()
        {
            int _counter = LL.Count();

            Assert.Equal(0, _counter);
        }

        [Fact]
        public void To_String()
        {
            LL.Add_First(312);
            LL.Add_First(12);
            LL.Add_First(72);
            string _result = LL.To_String();

            Assert.Equal("72, 12, 312, ", _result);
        }

        [Fact]
        public void Sort()
        {
            LL.Add_First(1222);
            LL.Add_First(2);
            LL.Add_First(12);

            LL.Sort();
            string _sortedList = LL.To_String();
            Assert.Equal("2, 12, 1222, ", _sortedList);
        }

        [Fact]
        public void SortEmpty()
        {
            LL.Sort();
            string _sortedList = LL.To_String();
            Assert.Equal("Empty.", _sortedList);
        }
    }
}