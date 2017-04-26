//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace LetterCounter
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<ulong> current;
//            //int current;
//            int max = 0;
//            // 492000000
//            //for (ulong i = 492000000; i < ulong.MaxValue; i++)
//            //for (ulong i = ulong.MaxValue; i > 1000; i--)
//            ulong i = 3333333333333333333;
//            {
//                if(i % 100000 == 0)
//                {
//                    Console.WriteLine(i);
//                    //GC.Collect(GC.MaxGeneration, GCCollectionMode.Optimized, false, false);
//                }
//                Task<string> result = Task.Factory.StartNew<string>(()=>
//                {
//                    //current = NumWordNumParse.FindPath(i);
//                    //if (current == max)
//                    //{
//                    //    return String.Format("NEW MAX {0}", current);
//                    //}
//                    //else if (current > max)
//                    //{
//                    //    max = current;
//                    //    return String.Format("NEW MAX {0}", current);
//                    //}
//                    current = NumberToWordParser.FindPath(i);
//                    if (current.Count == max)
//                    {
//                        return String.Format("NEW MAX {0} :: {1}{2}", current.Count, printList(current), Environment.NewLine);
//                    }
//                    else if (current.Count > max)
//                    {
//                        max = current.Count;
//                        return String.Format("NEW MAX {0} :: {1}{2}", current.Count, printList(current), Environment.NewLine);
//                    }
//                    return null;
//                });
//                string ret;
//                if (!string.IsNullOrEmpty(ret = result.Result))
//                {
//                    File.AppendAllText("stuff.txt", result.Result);
//                }
//            }
//            Console.ReadKey();
//        }
//        public static string printList(List<ulong> list)
//        {
//            StringBuilder build = new StringBuilder(30);
//            foreach (var item in list)
//            {
//                build.Append("=>").Append(item);
//            }
//            return build.ToString();
//        }
//    }
//}
