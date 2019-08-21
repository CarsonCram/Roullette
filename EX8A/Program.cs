using System;

namespace EX8A
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tEX8A.Program.Main()");

            Console.WriteLine("\n\tWelcome to Roullette");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\n\tWhat kind of bet would you like to make?");
            int bet = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\t|Numbers|Evens or Odds|Reds or Blacks|" +
                "Lows or Highs|Dozens|Columns|Streets|6 Numbers|Split|" +
                "Corner|");
            string GameType = Console.ReadLine();
            
            int winnings;

            if (GameType == "Numbers" || GameType == "numbers")
            {
                int num;

                Console.WriteLine("You've chosen to play numbers, Please select " +
                    "a number.");
                if (Console.ReadLine() == "00")
                    num = 37;
                else num = int.Parse(Console.ReadLine());
                

                if (num > 37 || num < 0)
                {
                    throw 
                }

                if (Bets.Numbers(num) == 1)
                    winnings = bet * 35;
            }

            if (GameType == "Evens or Odds" || GameType == "evens or odds")
            {
                Console.WriteLine("You've chosen to play Evens or odds," +
                    "Would you like to bet evens or odds?");
                string input = Console.ReadLine();

                if (Bets.EvenOrOdd(input) == 1)
                    winnings = bet;
            }
            if(GameType == "Reds or Blacks" || GameType == "reds or blacks")
            {
                Console.WriteLine("You've chosen to play Reds or Blacks, Would" +
                    "you like to bet reds or blacks?");
                string input = Console.ReadLine();

                if (Bets.RedsOrBlacks(input) == 1)
                    winnings = bet;
            }
            if(GameType == "Lows or Highs" || GameType == "lows or highs")
            {
                Console.WriteLine("You've chosen to play Lows or Highs, Would" +
                    "you like to bet lows or highs?");
                string input = Console.ReadLine();

                if (Bets.LowOrHigh(input) == 1)
                    winnings = bet;
            }
            if (GameType == "Dozens" || GameType == "dozens")
            {
                Console.WriteLine("You've chosen to play Dozens. Which dozen" +
                    "would you like to play: 1st, 2nd, or 3rd");
                string input = Console.ReadLine();

                if (Bets.Dozens(input) == 1)
                    winnings = bet * 2;
            }
            if (GameType == "Columns" || GameType == "columns")
            {
                Console.WriteLine("You've chosen to play Columns. Which column" +
                    "would you like to play: 1st, 2nd, or 3rd");
                string input = Console.ReadLine();

                if (Bets.Columns(input) == 1)
                    winnings = bet * 2;
            }
            if (GameType == "Streets" || GameType == "streets")
            {
                Console.WriteLine("You've chosen to play Streets. Which " +
                    "street would you like to play: Please choose the first number" +
                    "in the street. i.e. 1, 4, 7, etc.");
                int num = int.Parse(Console.ReadLine());

                if (Bets.Streets(num) == 1)
                    winnings = bet * 11;
            }
            if (GameType == "6 Numbers" || GameType == "6 numbers")
            {
                Console.WriteLine("You've chosen to play 6 Numbers. Which " +
                    "section would you like to play: Please choose the first number" +
                    "i.e. 1, 7, 13, etc.");
                int num = int.Parse(Console.ReadLine());

                if (Bets.DoubleRows(num) == 1)
                    winnings = bet * 16;
            }
            if (GameType == "Split" || GameType == "split")
            {
                Console.WriteLine("You've chosen to play Split. Which " +
                    "number would you like to split?");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("What number would you like to split that with?");
                int num2 = int.Parse(Console.ReadLine());          

                if (Bets.Split(num, num2) == 1)
                    winnings = bet * 17;
            }
            if (GameType == "Corner" || GameType == "corner")
            {
                Console.WriteLine("You've chosen to play Corner. Please pick the " +
                    "bottom left number of the corner you would like to play.");
                int num = int.Parse(Console.ReadLine());

                if (Bets.Corner(num) == 1)
                    winnings = bet * 8;
            }
        }
    }
}
