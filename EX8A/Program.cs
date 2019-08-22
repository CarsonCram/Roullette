using System;

namespace EX8A
{
    public class Program
    {
        public static int wallet = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tEX8A.Program.Main()");

            Console.WriteLine("\n\tWelcome to Roullette");
            Console.WriteLine();
            Console.WriteLine("\n\tYou will have 1000 dollars and ten bets to make" +
                " as much money as possible, good luck");
            Console.WriteLine();

            int turn = 10;
            bool won = false;

            do
            {
                string game = OtherStuff.GetGame();
                int bet = OtherStuff.GetBet();
            
                if (game == "Numbers")
                {
                    int result = Games.Numbers();

                    if (result == 1)
                        {
                            wallet += (bet * 35);
                            won = true;
                        }
                    else
                        {
                            wallet -= bet;
                            won = false;
                        }
                    turn--;
                }
                if (game == "Evens or Odds")
                {
                    int result = Games.EvensOrOdds();

                    if (result == 1)
                    {
                        wallet += bet;
                        won = true;
                    }
                    else
                    {
                        wallet -= bet;
                        won = false;
                    }
                    turn--;
                }
                if (game == "Reds or Blacks")
                {
                    int result = Games.RedsOrBlacks();

                    if (result == 1)
                    {
                        wallet += bet;
                        won = true;
                    }
                    else
                    {
                        wallet -= bet;
                        won = false;
                    }
                    turn--;
                }
                if (game == "Lows or Highs")
                {
                    int result = Games.LowsOrHighs();

                    if (result == 1)
                    {
                        wallet += bet;
                        won = true;
                    }
                    else
                    {
                        wallet -= bet;
                        won = false;
                    }
                    turn--;
                }
                if (game == "Dozens")
                {
                    int result = Games.Dozens();

                    if (result == 1)
                    {
                        wallet += bet;
                        won = true;
                    }
                    else
                    {
                        wallet -= bet;
                        won = false;
                    }
                    turn--;
                }
                if (game == "Columns")
                {
                    int result = Games.Columns();

                    if (result == 1)
                    {
                        wallet += (bet * 2);
                        won = true;
                    }
                    else
                    {
                        wallet -= bet;
                        won = false;
                    }
                    turn--;
                }
                if (game == "Streets")
                {
                    int result = Games.Streets();

                    if (result == 1)
                    {
                        wallet += (bet * 11);
                        won = true;
                    }
                    else
                    {
                        wallet -= bet;
                        won = false;
                    }
                    turn--;
                }
                if (game == "6 Numbers")
                {
                    int result = Games.DoubleRows();

                    if (result == 1)
                    {
                        wallet += (bet * 5);
                        won = true;
                    }
                    else
                    {
                        wallet -= bet;
                        won = false;
                    }
                    turn--;
                }
                if (game == "Split")
                {
                    int result = Games.Split();

                    if (result == 1)
                    {
                        wallet += (bet * 17);
                        won = true;
                    }
                    else
                    {
                        wallet -= bet;
                        won = false;
                    }
                    turn--;
                }
                if (game == "Corner")
                {
                    int result = Games.Corner();

                    if (result == 1)
                    {
                        wallet += (bet * 8);
                        won = true;
                    }
                    else
                    {
                        wallet -= bet;
                        won = false;
                    }
                    turn--;
                }

                if(won == true)
                {
                    Console.WriteLine($"Congrats you won! You now have ${wallet}");
                }
                else Console.WriteLine($"Sorry mate you lost, on the bright side you " +
                    $"still have ${wallet}");

            } while (wallet > 0 && turn > 0);

            if (turn == 0 && wallet >= 1000)
            {
                Console.WriteLine($"\n\tCongratulations you won {wallet - 1000}");
                Console.WriteLine($"\n\tYou're leaving the casino with {wallet}, " +
                    $"feel free to come again!");
            }
            else if (turn == 0 && wallet <= 1000)
            {
                Console.WriteLine("\n\tWe're very sorry you didn't have better luck," +
                    " maybe next time!");
            }
            else Console.WriteLine("\n\tI'm sorry you have nothing more to bet with, " +
                    "Sorry you didn't have much luck. Please come again!");
        }
    }
}
