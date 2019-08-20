using System;
using System.Collections.Generic;
using System.Text;

namespace EX8A
{
    public class Bets
    {
        //1 == true, 0 == false

        //determines whether the guess is the same as the rng used to 
        //represent the board.
        public static int Numbers(int num)
        {
            int i = new Random().Next( 1, 36);
            return i == num ? 1 : 0;
        }

        //since evens or odds is a 50/50 game I just used an rng of two 
        //numbers and compared the user input to the two number rng.
        public static int EvenOrOdd(string input)
        {
            int i = new Random().Next(1, 2);
            
            if ((input == "evens" || input == "Evens") && i == 2)
                return 1;
            if ((input == "odds" || input == "Odds") && i == 1)
                return 1;
            else return 0;
        }

        //same logic applies here from ^^
        public static int RedsOrBlacks(string input)
        {
            int i = new Random().Next(0,1);

            if ((input == "Reds" || input == "reds") && i == 1)
                return 1;
            if ((input == "Blacks" || input == "blacks") && i == 0)
                return 1;
            else return 0;
        }

        //same logic again ^^
        public static int LowOrHigh(string input)
        {
            int i = new Random().Next(1, 36);

            if ((input == "Lows" || input == "lows") && i < 19)
                return 1;
            if ((input == "Highs" || input == "highs") && i > 18)
                return 1;
            else return 0;
        }

        public static int Dozens(int num)
        {
            int i = new Random().Next(0, 2);

            if (num == 1 && i == 0)
                return 1;
            if (num == 2 && i == 1)
                return 1;
            if (num == 3 && i == 2)
                return 1;
            else return 0;
        }
            
        public static int Columns(int num)
        {
            int i = new Random().Next(1, 36);

            if (i % 3 == 0 && num == 3)
                return 1;
            if (i == 1 || i == 4 || i == 7 || i == 10 || i == 13 || i == 16
                || i == 19 || i == 22 || i == 25 || i == 28 || i == 31
                || i == 34 && num == 1)
                return 1;
            if (i == 2 || i == 5 || i == 8 || i == 11 || i == 14 || i == 17
                || i == 20 || i == 23 || i == 26 || i == 27 || i == 32
                || i == 35 && num == 2)
                return 1;
            else return 0;
        }

        //here i just make an rng between 1 and 12 and ask the user to provide
        //which street they would like to place a bet on. if the numbers aligns
        //the user wins.
        public static int Streets(int num)
        {
            int i = new Random().Next(1, 12);
            return i == num ? 1 : 0;
        }

        //same logic applies here ^^
        public static int DoubleRows(int num)
        {
            int i = new Random().Next(1, 6);
            return i == num ? 1 : 0;
        }

        public static int Split(int num, int num2)
        {
            int i = new Random().Next(1, 36);

            if(num2 == num + 1 || num2 == num - 1)
            {
                if((num == 3 && num2 == 4) || (num == 6 && num2 == 7) 
                    || (num == 9 && num2 == 10) || (num == 12 && num2 == 13)
                    || (num == 15 && num2 == 16) || (num == 18 && num2 == 19)
                    || (num == 21 && num2 == 22) || (num == 24 && num2 == 25)
                    || (num == 27 && num2 == 28) || (num == 30 && num2 == 31)
                    || (num == 33 && num2 == 34))
                {
                    //need to throw an exception since this move is invalid
                }
                if (i == num || i == num2)
                    return 1;
            }

            if (num2 == num + 3 || num2 == num - 3)
            {
                if((num == 1 && num2 == 35) || (num == 2 && num2 == 36))
                {
                    //^^
                }
                if (i == num || i == num2)
                    return 1;
            }
        }
    }
}
