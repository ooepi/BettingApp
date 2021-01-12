using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double odds = 0.75;

            Guy player = new Guy() {Name = "Player", Cash = 100 };


            Console.WriteLine("Welcome to the casino. The odds are " + odds);

            while (true)
            {
                
                Console.WriteLine("The " + player.Name + " Has " + player.Cash + " bucks.");

                Console.Write("How much do you want to bet: ");
                int bet = int.Parse(Console.ReadLine());

                player.GiveCash(bet);

                if (random.NextDouble() <= 0.75)
                {
                    Console.WriteLine("You win " + bet * 2);
                    player.ReceiveCash(bet * 2);
                }
                else
                {
                    Console.WriteLine("Bad luck, you lose");

                    if (player.Cash <= 0)
                    {
                        Console.WriteLine("The house always wins");
                        Console.ReadLine();
                        return;
                    }
                }
            }
        }
    }
}
