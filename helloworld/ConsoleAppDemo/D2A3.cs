using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class D2A3
    {
        public static String SwapNums(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            return $"a = {a},b = {b}";
        }    public static void Main()
    {
        Console.WriteLine("Enter 2 numbers");
        int a, b;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine($"a = {a},b = {b}");
        string str = SwapNums(ref a, ref b);
        Console.WriteLine(str);
    }
    }

}
