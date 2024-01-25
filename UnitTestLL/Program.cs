namespace UnitTestLL
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList LL = new LinkedList();

            LL.Add_First(132);
            Console.WriteLine(LL._baseElement.Data);


        }
    }
}
