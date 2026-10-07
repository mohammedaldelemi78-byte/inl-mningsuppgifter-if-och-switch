using System;
namespace Uppgift3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" för att få med i tävligen måste vi veta hur gamml du är hur hur gamml är du?");
            int ålder= int.Parse(Console.ReadLine());
            if (ålder >= 16 && ålder <=19)
                Console.WriteLine("grattis du kan vara med");
            else if (ålder < 16)
            {
                Console.WriteLine("sorry för för ung");
            }
            else
            {
                Console.WriteLine("sorry för gamml");
            }
        }
        

    }
}
