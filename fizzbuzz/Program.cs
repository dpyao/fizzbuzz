using System.Collections.Generic;

namespace fizzbuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            var printedList = program.getPrintedList();

            foreach (var i in printedList)
            {
                System.Console.WriteLine(i);
            }
        }

        public List<int> getPrintedList()
        {
            var printedList = new List<int>();

            for (var i = 1; i <= 100; i++)
            {
                printedList.Add(i);
            }
            return printedList;
        }
    }
}