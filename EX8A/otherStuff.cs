using System;

namespace EX8A
{
    public class OtherStuff
    {
        public static string GetGame()
        {
            bool exit = false;
            string input = "";

            do
            {
                Console.WriteLine("\n\tWhat would you like to bet on?");
                Console.WriteLine("\n\t|Numbers|Evens or Odds|Reds or Blacks|" +
                "Lows or Highs|Dozens|Columns|Streets|6 Numbers|Split|" +
                "Corner|");
                Console.WriteLine();
                input = Console.ReadLine();

                if (input == "Numbers" || input == "Evens or Odds"
                    || input == "Reds or Blacks" || input == "Lows or Highs"
                    || input == "Dozens" || input == "Columns"
                    || input == "Streets" || input == "6 Numbers" 
                    || input == "Split" || input == "Corner")
                    exit = true;
                else
                {
                    Console.WriteLine("Please select a valid bet, " +
                        "note that it is case sensitive");

                    exit = false;
                }
            } while (exit == false);
            return input;
        }

        public static string GetChoice(string input)
        {
            bool exit = false;
            int nums = int.Parse(input);

            do
            {
                if (nums <= 36 || nums >= 0 || input == "00")
                    exit = true;
                else
                {
                    Console.WriteLine("Please choose a number " +
                    "between 0 and 36, or 00");
                }
            } while (exit == false);
            return input;
        }

        public static int GetBet()
        {

            Console.WriteLine("How much would you like to bet?");
            int bet = int.Parse(Console.ReadLine());
            
            while (bet > Program.wallet)
            {
                Console.WriteLine("Sorry, you don't have the funds for that kind of bet," +
                    "Please bet something within your means.");
                bet = int.Parse(Console.ReadLine());
            }
            return bet;
        }
    }
}
