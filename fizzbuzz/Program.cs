using System.Collections.Generic;

namespace fizzbuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            var printedList = program.GetPrintedList();

            foreach (var i in printedList)
            {
                System.Console.WriteLine(i);
            }
        }

        public List<string> GetPrintedList()
        {
            var printedList = new List<string>();

            for (var i = 1; i <= 100; i++)
            {
                printedList.Add(GetPrintedStr(i));
            }
            
            return printedList;
        }

        private static string GetPrintedStr(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz";
            if (number % 3 == 0 || number.ToString().Contains("3")) return "Fizz";
            return number % 5 == 0 ? "Buzz" : number.ToString();
        }
    }
}