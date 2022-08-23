using System.Runtime.CompilerServices;

namespace ConsoleAppDemo2
{
    public class OutPutPara
    {
        public static int SmallestNum(int a, int b, out int c)
        {
            if (a > b)
            {
                c = a;
                return c;
            }
            else
            {
                c = b;
                return c;
            }

        }
        public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter the numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int res;
            res = SmallestNum(a, b,out c);
            Console.WriteLine($"{res} is the smallest number");
        }

    }

}
