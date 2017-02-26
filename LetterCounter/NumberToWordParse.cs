using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    
    public class NumberToWordParser
   { 
        static string[] ones = { "Zero" , "One", "Two", "Three", "Four","Five","Six","Seven","Eight","Nine" };
        static string[] teens = {"Ten", "Eleven","Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen","Nineteen" };
        static string[] tens = { "Ten", "Twenty","Thirty","Fourty","Fifty","Sixty","Seventy","Eighty","Ninety" };
        static string[] higher = { "Hundred","Thousand","Million","Billion","Trillion","Quadrillion", "Quintillion"};


        public static List<ulong> FindPath(ulong startVal)
        {
            List<ulong> lst = new List<ulong>();

            lst.Add(startVal);
            string current = convertToWord(startVal);
            string next = convertToWord((ulong)current.Length);

            while ((ulong)current.Length != (ulong)next.Length)
            {
                lst.Add((ulong)current.Length);
                current = next;
                next = convertToWord((ulong)current.Length);
                startVal = (ulong)current.Length;
            }
            lst.Add(startVal);
            return lst;
        }

        public static string convertToWord(ulong number)
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
                return RconvertToWord(number).TrimEnd('-');
            }
        }
        private static string RconvertToWord(ulong number)
        {
            if(number == 0)
            {
                return "";
            }
            if(number <= 9)
            {
                return ones[number] + "-";
            }
            else if (number <= 19)
            {
                return teens[number - 10] + "-";
            }
            else if( number <= 99)
            {
                return tens[(number / 10) - 1] + "-" + RconvertToWord(number % 10);
            }
            else if (number <= 999)
            {
                return RconvertToWord(number / 100) + higher[0] + "-" + RconvertToWord(number % 100);
            }
            else //if (number > 99)
            {
                short size = (short)Math.Ceiling(number.ToString().Length / 3.0); // total number of segments 10,030,003 => 3 segments
                
                // length of number minus the latter segments e.g. num 10,030,003 => 8("10,030,003") - 6("030,003") = 2
                short firstSegmentSize = (short)(number.ToString().Length - (3 * (size - 1)));

                string segment = number.ToString().Substring(0, firstSegmentSize); // get first segment
                int numSegment = int.Parse(segment); // parse to int

                ulong retSize = number - ((ulong)numSegment * (ulong)Math.Pow(10, 3*(size - 1)));
                return RconvertToWord((ulong)numSegment) + higher[size - 1] + "-" + RconvertToWord(retSize);
            }

        }
    }
}
