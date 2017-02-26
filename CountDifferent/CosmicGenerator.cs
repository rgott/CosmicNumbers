using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CountDifferent
{
    public class CosmicGenerator
    {
        static readonly Dictionary<string, int> lower = new Dictionary<string, int>() {
             { "Zero",0 }
            ,{ "One",1 }
            ,{ "Two",2 }
            ,{ "Three",3 }
            ,{ "Four",4 }
            ,{ "Five",5 }
            ,{ "Six",6 }
            ,{ "Seven",7 }
            ,{ "Eight",8 }
            ,{ "Nine",9 }
            ,{ "Ten", 10 }
            ,{ "Eleven", 11 }
            ,{ "Twelve", 12 }
            ,{ "Thirteen", 13 }
            ,{ "Fourteen", 14 }
            ,{ "Fifteen", 15 }
            ,{ "Sixteen", 16 }
            ,{ "Seventeen", 17 }
            ,{ "Eighteen", 18 }
            ,{ "Nineteen", 19 }
            ,{ "Twenty",20 }
            ,{ "Thirty",30 }
            ,{ "Fourty",40 }
            ,{ "Fifty",50 }
            ,{ "Sixty",60 }
            ,{ "Seventy",70 }
            ,{ "Eighty",80 }
            ,{ "Ninety",90 }};


        static readonly Dictionary<string, int> higher = new Dictionary<string, int>(){
             { "Hundred", 2 }// 7
            ,{ "Thousand",3 }// 8
            ,{ "Million",6 }// 7
            ,{ "Billion",9 }// 7
            ,{ "Trillion",12 }// 8
            ,{ "Quadrillion",15 }// 11
            ,{ "Quintillion",18 }// 11
            ,{ "Sextillion",21 }// 10
            ,{ "Septillion",24 }// 10
            ,{ "Octillion",27 }// 9
            ,{ "Nonillion",30 }// 9
            ,{ "Decillion",33 }// 9
            ,{ "Undecillion",36 }// 11
            ,{ "Duodecillion",39 }// 12
            ,{ "Tredecillion",42 }// 12
            ,{ "Quattuordecillion",45 }// 17
            ,{ "Quindecillion",48 }// 13
            ,{ "Sexdecillion",51 }// 12
            ,{ "Septendecillion",54 }// 15
            ,{ "Octodecillion",57 }// 13
            ,{ "Novemdecillion",60 }};// 14

        public void generator(string LastGenerated = "Eleven")
        {
            using (var stream = File.AppendText("file.txt"))
            using (var stream2 = File.AppendText("file1.txt"))
            {

                stream.WriteLine(LastGenerated);
                stream2.WriteLine(11);
                stream2.Flush();
                stream.Flush();

                while (true)
                {
                    var value = NumberToFindNumberWithLetters(convertToNumber(LastGenerated));
                    stream2.WriteLine(value);
                    stream2.Flush();

                    LastGenerated = convertToWord(value);
                    stream.WriteLine(LastGenerated);
                    stream.Flush();
                }
            }
        }


        public static BigInteger NumberToFindNumberWithLetters(BigInteger Number)
        {
            Stack<byte> stack = new Stack<byte>();
            var returns = new BigInteger(0);

            // remember to add first 3 after while
            // 
            int max = 23;
            while (Number >= max)
            {
                stack.Push(3);
                if ((Number -= 15) <= max)
                    break;

                stack.Pop();
                stack.Push(7);
                stack.Push(1);
                if (Number - 4 <= max)
                    break;

                stack.Push(3);
                if (Number - 14 <= max)
                    break;
            }

            while (stack.Count > 0)
            {
                byte num = stack.Pop();
                returns *= 10;
                returns += num;
            }

            var last3 = new Stack<byte>();
            #region SWitch
            switch ((int)Number)
            {
                case 3:
                    last3.Push(6);
                    last3.Push(0);
                    last3.Push(0);
                    break;
                case 4:
                    last3.Push(4);
                    last3.Push(0);
                    last3.Push(0);
                    break;
                case 5:
                    last3.Push(3);
                    last3.Push(0);
                    last3.Push(0);
                    break;
                case 6:
                    last3.Push(1);
                    last3.Push(1);
                    last3.Push(0);
                    break;
                case 7:
                    last3.Push(5);
                    last3.Push(1);
                    last3.Push(0);
                    break;
                case 8:
                    last3.Push(3);
                    last3.Push(1);
                    last3.Push(0);
                    break;
                case 9:
                    last3.Push(7);
                    last3.Push(1);
                    last3.Push(0);
                    break;
                case 10:
                    last3.Push(4);
                    last3.Push(5);
                    last3.Push(0);
                    break;
                case 11:
                    last3.Push(3);
                    last3.Push(5);
                    last3.Push(0);
                    break;
                case 12:
                    last3.Push(3);
                    last3.Push(2);
                    last3.Push(0);
                    break;
                case 13:
                    last3.Push(3);
                    last3.Push(7);
                    last3.Push(0);
                    break;
                case 14:
                    throw new NotImplementedException();
                case 15:
                    last3.Push(6);
                    last3.Push(0);
                    last3.Push(6);
                    break;
                case 16:
                    last3.Push(6);
                    last3.Push(0);
                    last3.Push(4);
                    break;
                case 17:
                    last3.Push(6);
                    last3.Push(0);
                    last3.Push(3);
                    break;
                case 18:
                    last3.Push(4);
                    last3.Push(0);
                    last3.Push(3);
                    break;
                case 19:
                    last3.Push(3);
                    last3.Push(0);
                    last3.Push(3);
                    break;
                case 20:
                    last3.Push(1);
                    last3.Push(1);
                    last3.Push(3);
                    break;
                case 21:
                    last3.Push(5);
                    last3.Push(1);
                    last3.Push(3);
                    break;
                case 22:
                    last3.Push(3);
                    last3.Push(1);
                    last3.Push(3);
                    break;
                case 23:
                    last3.Push(7);
                    last3.Push(1);
                    last3.Push(3);
                    break;
                default:
                    break;
            }
            #endregion

            while (last3.Count > 0)
            {
                byte num = last3.Pop();
                returns *= 10;
                returns += num;
            }

            return returns;
        }


        public static BigInteger convertToNumber(string Number, char splitOn = '-')
        {
            return convertToNumber(Number.Split(splitOn));
        }

        public static BigInteger convertToNumber(string[] NumberChunk)
        {
            BigInteger total = BigInteger.Zero;

            int value;
            BigInteger _sto = BigInteger.Zero;
            for (int i = 0; i < NumberChunk.Length; i++)
            {
                if (lower.TryGetValue(NumberChunk[i], out value))
                {
                    // if here again then count number
                    total += _sto;

                    // here then number
                    _sto = value;
                }
                else if (higher.TryGetValue(NumberChunk[i], out value))
                {
                    // multiply previous number
                    var zeroHolder = BigInteger.Pow(new BigInteger(10), value);

                    _sto = BigInteger.Multiply(zeroHolder, _sto);
                }

            }
            total += _sto;
            return total;
        }

        public static string convertToWord(BigInteger number)
        {
            if (number <= 19)
            {
                return lower.FirstOrDefault(n => n.Value == number).Key;
            }
            else
            {
                return RconvertToWord(number).TrimEnd('-');
            }
        }
        private static string RconvertToWord(BigInteger number)
        {
            if(number == 0)
            {
                return "";
            }
            if(number <= 19)
            {
                return lower.FirstOrDefault(n => n.Value == number).Key + "-";
            }
            else if( number <= 99)
            {
                return lower.FirstOrDefault(n => n.Value == (number / 10 * 10)).Key + "-" + RconvertToWord(number % 10);
            }
            else if (number <= 999)
            {
                return RconvertToWord(number / 100) + higher.ElementAt(0).Key + "-" + RconvertToWord(number % 100);
            }
            else //if (number > 99 }
            {
                short size = (short)Math.Ceiling(number.ToString().Length / 3.0); // total number of segments 10,030,003 => 3 segments

                // length of number minus the latter segments e.g. num 10,030,003 => 8("10,030,003" } - 6("030,003" } = 2
                short firstSegmentSize = (short)(number.ToString().Length - (3 * (size - 1)));

                string segment = number.ToString().Substring(0, firstSegmentSize); // get first segment
                BigInteger numSegment = BigInteger.Parse(segment); // parse to int

                BigInteger retSize = number - ((ulong)numSegment* (ulong)Math.Pow(10, 3*(size - 1)));
                return RconvertToWord(numSegment) + higher.ElementAt(size - 1).Key + "-" + RconvertToWord(retSize);
            }

        }
    }
}
