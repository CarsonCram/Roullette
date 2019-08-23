using System;

namespace EX8A
{
    public class Bets
    {
        //this will be my universal RNG used to represent where
        //the ball lands on the board. 0 == 0, 37 == 00
        public static int RNG()
        {
            int i = new Random().Next(0, 38);
            return i;
        }

        //1 == true, 0 == false

        //determines whether the guess is the same as RNG
        public static int Numbers(int num)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            return num == r ? 1 : 0;
        }

        //EvenOrOdd is a 49/49/2 bet so I split the RNG 3 ways
        public static int EvenOrOdd(string input)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            if (r == 0 || r == 37)
                return 0;
            else if ((input == "Evens") || (input == "evens")
                && r % 2 == 0)
                return 1;
            else if ((input == "Odds" || input == "odds") && r % 2 == 1)
                return 1;
            else return 0;
        }

        //^^
        public static int RedsOrBlacks(string input)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            if (r == 0 || r == 37)
                return 0;
            else if (input == "Reds" || input == "reds")
            {
                for (int i = 0; i < Board.reds.Length - 1; i++)
                {
                    if (Board.reds[i] == r)
                        return 1;
                }
            }            
            else if (input == "Blacks" || input == "blacks")
            {
                for (int i = 0; i < Board.blacks.Length - 1; i++)
                {
                    if (Board.blacks[i] == r)
                        return 1;
                }
            } 
            else return 0;
            return 0;
        }

        //^^
        public static int LowOrHigh(string input)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            if (r == 0 || r == 37)
                return 0;
            else if ((input == "Lows" || input == "lows") && r < 19)
                return 1;
            else if ((input == "Highs" || input == "highs") && r > 18)
                return 1;
            else return 0;

        }

        //this is almost a 33/33/33 chance on this bet. But it's important to remember 
        //the green areas on the board which alters the math a bit.
        
        //TLDR: this is a four way split on the RNG
        public static int Dozens(string input)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            if (r == 0 || r == 37)
                return 0;
            else if (input == "1st" && r < 13)
                return 1;              
            else if (input == "3rd" && r > 24)
                return 1;              
            else if (input == "2nd" && r < 25 && RNG() > 12)
                return 1;
            else return 0;
        }
            
        //^^
        public static int Columns(string input)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            if (r == 0 || r == 37)
                return 0;
            else if (input == "1st")
            {
                for (int i = 0; i < Board.firstColumn.Length - 1; i++)
                {
                    if (r == Board.firstColumn[i])
                        return 1;
                }
            }
            else if (input == "2nd")
            {
                for (int i = 0; i < Board.secondColumn.Length - 1; i++)
                {
                    if (r == Board.secondColumn[i])
                        return 1;
                }
            }
            else if (input == "3rd")
            {
                for (int i = 0; i < Board.thirdColumn.Length - 1; i++)
                {
                    if (r == Board.thirdColumn[i])
                        return 1;
                }
            }
            else return 0;
            return 0;
        }

        //here I ask the user to give me the first number of the street 
        //which makes it really easy to calculate.
        public static int Streets(int num)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            if (r == 0 || r == 00)
                return 0;
            else if (r == num || r == num + 1 || r == num + 2)
                return 1;
            else return 0;
        }

        //I ask the question in a way that's really easy for me to 
        //calculate the result
        public static int DoubleRows(int num)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            if (r == 0 || r == 37)
                return 0;
            else if (r >= num && r <= num + 5)
                return 1;
            else return 0;
        }

        //I created a jagged array to find the numbers directly next to the user inputs
        //there may be a bug here though, I have to review this
        public static int Split(int num, int num2)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            if (r == 0 || r == 37)
                return 0;
            else
            {
                if (Board.Rows[i][num] == r || Board.Rows[][num2] == r)
                    return 1;
                else return 0;
            }
            else
            {
                if (Board.Columns[0][num] == r || Board.Columns[1][num] ==r 
                    || Board.Columns[2][num] == r)
            }
        }

        //manipulated the user input question to make this easy.
        public static int Corner(int num)
        {
            int r = RNG();

            if (r == 37)
                Console.WriteLine("The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {r}");

            if (r == 0 || r == 37)
                return 0;
            else if (num % 3 == 0 || num == 35 || num == 34)
                return 0;
            else if (r == num || r == num + 1 || r == num + 3 
                || r == num + 4)
                return 1;
            else return 0;
        }
    }
}