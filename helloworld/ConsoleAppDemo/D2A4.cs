using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class D2A4
    {
        public static int AddDigits(string str)
        {
            int num, sum, m;
            num = int.Parse(str);
            sum = 0;
            while (num > 0)
            {
                m = num % 10;
                sum = sum + m;
                num = num / 10;
            }
            return sum;
        }
        public static int Reverse(string str)
        {

            int num, l, m;
            string rev;
            num = int.Parse(str);
            rev = null;
            while (num > 0)
            {
                m = num % 10;
                rev = rev + m.ToString();
                num = num / 10;
            }
            l = int.Parse(rev);
            return l;
        }
        public static string SwapSecThird(string str)
        {
            string fin;
            fin = str.Substring(0, 1) + str.Substring(2, 1) + str.Substring(1, 1) + str.Substring(3, 1);
            return fin;

        }
        public static string SwapFirstLast(string str)
        {
            string result;
            result = str.Substring(3, 1) + str.Substring(0, 1) + str.Substring(1, 1) + str.Substring(2, 1);
            return result;

        }
        public static void Main()
        {
            int i;
            Console.WriteLine("Enter a 4 digit number");
            i = int.Parse(Console.ReadLine());
            string str;
            str = i.ToString();
            if (str.Length != 4)
            {
                Console.WriteLine("INVALID NUMBER LENGTH");
            }
            else
            {
                int res = AddDigits(str);
                Console.WriteLine($"{res} is the sum of the digits");
                int revint = (Reverse(str));
                Console.WriteLine($"{revint} is the reverse of the number");
                int swapint = int.Parse(SwapSecThird(str));
                Console.WriteLine($"{swapint} is the result when second and third digits are swapped");
                int swapend = int.Parse(SwapFirstLast(str));
                Console.WriteLine($"{swapend} is the result when end is added to the front");

            }


        }
    }
}
