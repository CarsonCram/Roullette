using System;

namespace EX8A
{
    class Games
    {
        public static int Numbers()
        {
            Console.WriteLine("You've chosen to play numbers, please choose a " +
               "number between 0 and 36, or 00");
            int num = int.Parse(OtherStuff.GetChoice(Console.ReadLine()));

            if (Bets.Numbers(num) == 1)
                return 1;
            else
                return 0;
        }  

        public static int EvensOrOdds()
        {
            Console.WriteLine("You've chosen to play Evens or odds," +
                    " Would you like to bet evens or odds?");
            string input = Console.ReadLine();

            if (Bets.EvenOrOdd(input) == 1)
                return 1;
            else return 0;
        }

        public static int RedsOrBlacks()
        {
            Console.WriteLine("You've chosen to play Reds or Blacks," +
                " Would you like to bet reds or blacks?");
            string input = Console.ReadLine();

            if (Bets.RedsOrBlacks(input) == 1)
                return 1;
            else return 0;
        }

        public static int LowsOrHighs()
        {
            Console.WriteLine("You've chosen to play Lows or Highs, Would" +
                    " you like to bet lows or highs?");
            string input = Console.ReadLine();

            if (Bets.LowOrHigh(input) == 1)
                return 1;
            else return 0;
        }

        public static int Dozens()
        {

            Console.WriteLine("You've chosen to play Dozens. Which dozen" +
                " would you like to play: 1st, 2nd, or 3rd");
            string input = Console.ReadLine();

            if (Bets.Dozens(input) == 1)
                return 1;
            else return 0;
        }

        public static int Columns()
        {

            Console.WriteLine("You've chosen to play Columns. Which column" +
                " would you like to play: 1st, 2nd, or 3rd");
            string input = Console.ReadLine();

            if (Bets.Columns(input) == 1)
                return 1;
            else return 0;
        }
        
        public static int Streets()
        {
            Console.WriteLine("You've chosen to play Streets. Which " +
                "street would you like to play: Please choose the first number" +
                " in the street. i.e. 1, 4, 7, etc.");
            int num = int.Parse(OtherStuff.GetChoice(Console.ReadLine()));

            if (Bets.Streets(num) == 1)
                return 1;
            else return 0;
        }

        public static int DoubleRows()
        {
            Console.WriteLine("You've chosen to play 6 Numbers. Which " +
                "section would you like to play: Please choose the first number" +
                " i.e. 1, 7, 13, etc.");
            int num = int.Parse(OtherStuff.GetChoice(Console.ReadLine()));

            if (Bets.DoubleRows(num) == 1)
                return 1;
            else return 0;
        }

        public static int Split()
        {
            Console.WriteLine("You've chosen to play Split. Which " +
                "number would you like to split?");
            int num = int.Parse(OtherStuff.GetChoice(Console.ReadLine()));
            Console.WriteLine("What number would you like to split that with?");
            int num2 = int.Parse(OtherStuff.GetChoice(Console.ReadLine()));

            
            if (Bets.Split(num, num2) == 1)
                return 1;
            else return 0;
        }
        public static int Corner()
        {
            Console.WriteLine("You've chosen to play Corner. Please pick the " +
                "bottom left number of the corner you would like to play.");
            int num = int.Parse(OtherStuff.GetChoice(Console.ReadLine()));

            if (Bets.Corner(num) == 1)
                return 1;
            else return 0;
        }
    }
}
