using System;
namespace Uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många timmar vill du hyra bilen?");
            int timmar =int.Parse(Console.ReadLine().ToLower());
            int summa = (timmar * 80);
            if (summa >=950)
            {
                Console.WriteLine("din kostnad är 950kr");
            }
            else if(timmar > 0)
            {
                Console.WriteLine(" det kommer att kosta " + summa + " kr ");
            }
            else
            {
                Console.WriteLine("du kan inte tyvär hyra bilen");
            }
        }
    }
}
