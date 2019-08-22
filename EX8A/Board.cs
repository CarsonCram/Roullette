using System;
using System.Collections.Generic;
using System.Text;

namespace EX8A
{
    class Board
    {
        public static int[] blacks = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24,
            26, 28, 29, 31, 33, 35 };

        public static int[] reds = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25,
            27, 30, 32, 34, 36 };

        public static int[] firstColumn = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

        public static int[] secondColumn = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };

        public static int[] thirdColumn = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public static int[][] Rows =
        {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9},
            new int[] {10,11,12},
            new int[] {13,14,15},
            new int[] {16,17,18},
            new int[] {19,20,21},
            new int[] {22,23,24},
            new int[] {25,26,27},
            new int[] {28,29,30},
            new int[] {31,32,33}
        };

        public static int[][] Columns =
        {
            new int[] {1,4,7,10,13,16,19,22,25,28,31,34},
            new int[] {2,5,8,11,14,17,20,23,26,29,32,35},
            new int[] {3,6,9,12,15,18,21,24,27,30,33,36}
        };
    }
}
