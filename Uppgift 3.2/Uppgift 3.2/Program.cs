using System;
using System.Security.Cryptography.X509Certificates;
namespace Uppgift3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut från gymnasiet alså klarat");
            Console.WriteLine("j - ja ");
            Console.WriteLine("n - nej");
            string svar= Console.ReadLine();
            Console.WriteLine("Hur gammal är du");
            int ålder = int.Parse(Console.ReadLine().ToLower());

            if (svar == "j" && ålder>22)
            {
                Console.WriteLine("vi vill gärn anställa dig");
            }

            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }
         










            
        }
    }

}
