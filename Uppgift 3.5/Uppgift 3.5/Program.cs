using System;
namespace Uppgift3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in fösta talet");
            Double tal1=double.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("skriv in andra talet");
            Double tal2 = double.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("välj vilken räknasätt du vill använda fö dem två talet");
            Console.WriteLine("1. addition");
            Console.WriteLine("2.Subtraktion");
            Console.WriteLine("3.Multiplikation");
            Console.WriteLine("4.divison");
            string val=Console.ReadLine();
            switch(val)
            {
                case "1":
                    Console.WriteLine(tal1+tal2);
                    break;
                case "2":
                    Console.WriteLine(tal1-tal2);
                    break;
                    case "3":
                    Console.WriteLine(tal1*tal2);
                    break;
                    case"4":
                    Console.WriteLine(tal1/tal2);
                    break;
            }



        }
        
    }
}
