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

        public List<string> getPrintedList()
        {
            var printedList = new List<string>();

            for (var i = 1; i <= 100; i++)
            {
                printedList.Add(i % 3 == 0 ? "Fizz" : i.ToString());
            }
            return printedList;
        }
    }
}