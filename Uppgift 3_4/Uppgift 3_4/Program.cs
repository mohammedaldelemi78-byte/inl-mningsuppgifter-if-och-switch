using System;
namespace Uppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hur lång är din lått");
            Console.WriteLine(" i minuter");
            int längd = int.Parse(Console.ReadLine());
            Console.WriteLine(" i Sekunder");
            int sek=int.Parse(Console.ReadLine());
            if (längd < 2 && längd >= 4)
            {

            }

            else if (sek < 45 && sek >= 20)
            {
                Console.WriteLine("grattis du får spela in din låt");
            }
            else
            {
                Console.WriteLine("den får inte spelas på radiostationen");
            }
             
        }
    }
}