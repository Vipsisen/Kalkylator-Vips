using System;
using System.Collections.Generic;

namespace Kalkylator_Vips
{
    class Program
    {
        static void Main(string[] args)
        {
            void Hello()
            {
                Console.Write("Hallå där. Vad heter du? ");
                string user = Console.ReadLine();
                Console.WriteLine("Välkommen hit, {0}!! Den här kalkylatorn är simpel.", user);
                Console.ReadKey();
                Console.WriteLine("Du kommer mata in två tal och välja vad för räknesätt du vill använda.");
                Console.ReadKey();
                Console.WriteLine("Räknesätten du kan använda är addition, subtraktion, multiplikation samt division.");
                Console.ReadKey();
                Console.WriteLine("Alltså +, -, * och /.");
                Console.ReadKey();
            }

            bool runAgain = true;
            int i = 0;
            List<string> listan = new();
            double result = 0;
            string uträkning;

            Hello();
            do
            {
                Console.Write("Mata in ett tal: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Välj ett räknesätt: ");
                string op = Console.ReadLine();
                Console.Write("Mata in ytterligare ett tal: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine(result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine(result);
                        break;
                    case "*":
                    case "x":
                        result = num1 * num2;
                        Console.WriteLine(result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("Jag förstår tyvärr inte. Gör du? Vi börjar om!");
                        break;
                }
                void LäggTill()
                {
                    uträkning = num1 + op + num2 + "=" + result;
                    listan.Add(uträkning);
                    i++;
                }

                LäggTill();



                Console.Write("Vill du göra en till uträkning? [J/N] ");
                char svar = Convert.ToChar(Console.ReadLine());
                if (svar == 'j' || svar == 'J')
                {
                    runAgain = true;

                }
                else if (svar == 'n' || svar == 'N')
                {
                    Console.Write("Vill du se alla dina uträkningar? [J/N] ");
                    svar = Convert.ToChar(Console.ReadLine());
                    if (svar == 'j' || svar == 'J')
                    {
                        for (int n = 0; n < i; n++)
                        {
                            Console.WriteLine(listan[n]);
                        }
                        runAgain = false;

                    }
                    else if (svar == 'n' || svar == 'N')
                    {
                        runAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning. Vi börjar om!");
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning. Vi börjar om!");
                }



            } while (runAgain == true);
            Console.WriteLine("Tack för ditt tålamod! Så här går du till väga om du är missnöjd:");
            Console.ReadKey();
            Console.WriteLine("Skriv ned synpunkter på en lapp.");
            Console.ReadKey();
            Console.WriteLine("Kasta lappen i papperskorgen!");
        }
    }
}
