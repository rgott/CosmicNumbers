using System;
using System.Collections.Generic;

namespace LetterCounter
{
    class NumWordNumParse
    {
        static ulong[] ones = { 4, 3, 3, 5, 4, 4, 3, 5, 5, 4 };
        static ulong[] teens = { 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
        static ulong[] tens = { 3, 6, 6, 6, 5, 5, 7, 6, 6 };
        static ulong[] higher = { 7, 8, 7, 7, 8, 11, 11 };


        public static int FindPath(ulong startVal)
        {
            int length = 2;

            ulong current = convertToWord(startVal);
            ulong next = convertToWord(current);

            while (current != next)
            {
                length++;
                current = next;
                next = convertToWord(current);
                startVal = current;
            }
            return length;
        }

        public static ulong convertToWord(ulong number)
        {
            if (number == 0)
            {
                return ones[0];
            }
            if (number <= 9)
            {
                return ones[number];
            }
            else if (number <= 19)
            {
                return teens[number - 10];
            }
            else
            {
                return RconvertToWordNum(number);
            }
        }
        private static ulong RconvertToWordNum(ulong number)
        {
            if (number == 0)
            {
                return 0;
            }
            if (number <= 9)
            {
                return ones[number] + 1;
            }
            else if (number <= 19)
            {
                return teens[number - 10] + 1;
            }
            else if (number <= 99)
            {
                return tens[(number / 10) - 1] + 1 + RconvertToWordNum(number % 10);
            }
            else if (number <= 999)
            {
                return RconvertToWordNum(number / 100) + higher[0] + 1 + RconvertToWordNum(number % 100);
            }
            else //if (number > 99)
            {
                short size = (short)Math.Ceiling(number.ToString().Length / 3.0); // total number of segments 10,030,003 => 3 segments

                // length of number minus the latter segments e.g. num 10,030,003 => 8("10,030,003") - 6("030,003") = 2
                int firstSegmentSize = (number.ToString().Length - (3 * (size - 1)));

                short numSegment = (short)(number / (ulong)Math.Pow(10, 3 * (size - 1)));

                ulong retSize = number - ((ulong)numSegment * (ulong)Math.Pow(10, 3 * (size - 1)));
                return RconvertToWordNum((ulong)numSegment) + higher[size - 1] + 1 + RconvertToWordNum(retSize);
            }
        }
    }
}
