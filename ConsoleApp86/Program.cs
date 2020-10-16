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
                    switch (data)
                    {
                        case "0":
                        case "None":
                            ++count[0];
                            break;
                        case "1":
                        case "First":
                            ++count[1];
                            break;
                        case "2":
                        case "Second":
                            ++count[2];
                            break;
                        case "3":
                        case "Third":
                            ++count[3];
                            break;
                        case "4":
                        case "Fourth":
                            ++count[4];
                            break;
                        default:
                            notValidData += $",{data}";
                            break;
                    }
                }
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
                    notValidData = notValidData.Substring(1);
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
