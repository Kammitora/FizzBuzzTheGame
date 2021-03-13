using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz game = new FizzBuzz();
            while (true)
            {
            Console.WriteLine(game.LetsPlay()); 
            }
        }
    }
}
