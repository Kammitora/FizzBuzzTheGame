using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTheGame
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
            Console.WriteLine("Witaj w grze 'FizzBuzz'!\n");
            Console.WriteLine("ZASADY:\n-Jeżeli liczba użytkownika będzie podzielna przez 3 bez reszty, to powinien zostać zwrócony wynik „Fizz”.\n" +
                "- Jeżeli liczba użytkownika będzie podzielna przez 5 bez reszty, to powinien zostać zwrócony wynik „Buzz”.\n" +
                "-Jeżeli liczba użytkownika będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to powinien zostać zwrócony wynik „FizzBuzz”.\n" +
                "-Jeżeli liczba użytkownika nie będzie podzielna przez 3 ani przez 5 bez reszty, to wtedy zwracasz podaną liczbę.\n" +
                "- Jeśli chcesz zakończyć program, wpisz X\n\n" +
                "POWODZENIA! :)\n");
        }

        public string LetsPlay()
        {
            Console.Write("Wpisz Liczbę (wpisz X żeby zakończyć program): ");

            while (true)
            {
                var input = Console.ReadLine();


                if (input.ToUpper() == "X")
                    Environment.Exit(0);


                if(!int.TryParse(input, out int numberInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Błąd! Podaj liczbę całkowitą, spróbuj jeszcze raz.\n");
                    Console.ResetColor();
                    Console.WriteLine("Wpisz Liczbę (wpisz X żeby zakończyć program): ");
                    continue;
                }

                if ((numberInput % 3 == 0) && (numberInput % 5 == 0))
                {
                    return "FizzBuzz\n";

                }
                else if (numberInput % 5 == 0)
                {
                    return "Buzz\n";
                }
                else if (numberInput % 3 == 0)
                {
                    return "Fizz\n";
                }
                else
                {
                    return numberInput.ToString()+"\n";
                }
            }
        }
    }
}
