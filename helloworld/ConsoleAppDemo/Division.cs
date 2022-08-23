using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class Division
    {
        public static int division(int a, int b, out int res)
        {
            if (a>b)
            {
                return res = a / b;
            }
            else
            {
                return res = b / a;
            }
        }
        public static void main()
        {
            int a, b, res;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            res = division(a, b, out res);
            Console.WriteLine($"{res} is the result of the operation");
        }
    }
}
