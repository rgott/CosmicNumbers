using Algorithm.Numerics;
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
        public void Generator(string LastGenerated = "Eleven")
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
                    Console.WriteLine("START LETTER");
                    var value = NumberToFindNumberWithLetters(NumberUtils.ConvertToNumber(LastGenerated));
                    stream2.WriteLine(value);
                    stream2.Flush();

                    Console.WriteLine("START WORD");

                    LastGenerated = NumberUtils.ConvertToWord(value);
                    stream.WriteLine(LastGenerated);
                    Console.WriteLine(LastGenerated);
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

            Console.WriteLine(last3.Count);
            while (last3.Count > 0)
            {
                byte num = last3.Pop();
                returns *= 10;
                returns += num;
            }

            return returns;
        }
    }
}
