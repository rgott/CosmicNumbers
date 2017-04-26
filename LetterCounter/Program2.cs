using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    class Program2
    {
        // first tried to bruit force
        // got to half a billion over night and 
        // then went from highest to lowest got 8 string
        // then wanted to go from lowest to highest
        public static void Main()
        {
            ulong start = 113;

            Console.WriteLine(start);
            List<ulong> chain = new List<ulong>();
            chain.Add(start);

            ulong current;
            while (true)
            {
                current = 1111111;
                while (start != NumWordNumParse.convertToWord(current))
                {
                    Console.WriteLine(NumWordNumParse.convertToWord(current));
                    current +=1;
                    if (current == start)
                        current+=1;
                }
                start = current;
                chain.Add(start);
                Console.WriteLine(start);
            }
        }
    }
}
