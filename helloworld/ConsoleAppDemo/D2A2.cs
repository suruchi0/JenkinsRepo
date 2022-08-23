using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class D2A2
    {
        public static int MultiplyThreeNums( int a, int b, int c)
        {
            return a * b * c;   
        }
        public static void Main()
        {
            int a, b, c, res;
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());    
            c=int.Parse(Console.ReadLine());   
            res = MultiplyThreeNums((int)a, (int)b, (int)c);
            Console.WriteLine($"{res} is the product of the given numbers");
        }
    }
}
