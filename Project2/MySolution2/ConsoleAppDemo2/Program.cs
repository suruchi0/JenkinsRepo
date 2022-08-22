namespace ConsoleAppDemo2
{
    internal class ValRefTypes
    {
        public static void Main()
        {
            int n, m, o, p;
            Console.WriteLine("Enter the 3 numbers");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            o = int.Parse(Console.ReadLine());
            p = m * n * o;
            Console.WriteLine($"The Product is {p}");
        }

    }

}
