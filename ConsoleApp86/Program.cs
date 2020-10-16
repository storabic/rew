using System;

namespace Task12
{
    class Program
    {
        //public enum DataType
        //{
        //    None = 0,
        //    First = 1,
        //    Second = 2,
        //    Third = 3,
        //    Fourth = 4
        //}

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',');
            if (input.Length > 0)
            {
                int[] count = new int[5];
                string notValidData = "";
                foreach (var data in input)
                {
                    if (data == "0" || data == "None")
                        ++count[0];
                    else if (data == "1" || data == "First")
                        ++count[1];
                    else if (data == "2" || data == "Second")
                        ++count[2];
                    else if (data == "3" || data == "Third")
                        ++count[3];
                    else if (data == "4" || data == "Fourth")
                        ++count[4];
                    else
                        notValidData += $",{data}"; 
                }
                notValidData = notValidData.Substring(1);
                String ans;
                if (notValidData.Length < 1)
                {
                    ans = "Input data types:\n" +
                    $"None(0)-{count[0]}\n" +
                    $"First(1)-{count[1]}\n" +
                    $"Second(2)-{count[2]}\n" +
                    $"Third(3)-{count[3]}\n" +
                    $"Fourth(4)-{count[4]}\n";
                }
                else
                {
                    ans = "Input data types:\n" +
                 $"None(0)-{count[0]}\n" +
                 $"First(1)-{count[1]}\n" +
                 $"Second(2)-{count[2]}\n" +
                 $"Third(3)-{count[3]}\n" +
                 $"Fourth(4)-{count[4]}\n" +
                 $"Errors:\n" +
                 $"Not valid input strings: {notValidData}";
                }
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine("No data");
            }
        }
    }
}