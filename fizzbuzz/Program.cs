using System.Collections.Generic;

namespace fizzbuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var printedList = GetPrintedList();

            foreach (var i in printedList)
            {
                System.Console.WriteLine(i);
            }
        }

        public static List<string> GetPrintedList()
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
            if (number % 5 == 0 || number.ToString().Contains("5")) return "Buzz";

            return number.ToString();
        }
    }
}