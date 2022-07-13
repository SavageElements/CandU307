using System;

namespace CandU307
{
    class Program
    {

        static void Main(string[] args)
        {
           

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number");
            int xHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In " + xHours + " hours, it will be:");

            DateTime now = DateTime.Now;
            DateTime D2 = now.AddHours(+xHours);
            Console.WriteLine(D2);
        }
    }
}
