namespace UnitTestLL
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList LL = new LinkedList();
            Element _startElement = new(0, null);
            Element _secondElement = new(521, null);
            Element _thirdElement2 = new(35, null);
            Element _thirdElement3 = new(3, null);
            Element _thirdElement4 = new(1233, null);
            Element _thirdElement5 = new(23, null);
            _startElement.Next = _secondElement;
            _secondElement.Next = _thirdElement2;
            _thirdElement2.Next = _thirdElement3;
            _thirdElement3.Next = _thirdElement4;
            _thirdElement4.Next = _thirdElement5;

            Element _newElement = new(2501, null);

            //LL.Add_First(_startElement, _newElement);
            //LL.Remove_First();

            LL.Sort(_startElement);
        }
    }
}
