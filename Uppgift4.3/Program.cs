using System;
namespace Uppgift4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) //Lägger till fizz och buzz om det är delbart med 3 resp. 5
                {
                    svar = "Fizz";
                }
                if (i % 5 == 0)
                {
                    svar += "Buzz";
                }

                if (svar == "") // om det inte är delbart är svar "" så i skrivs istället
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(svar);
                }

                svar = "";
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}