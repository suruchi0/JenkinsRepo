namespace ConsoleAppDemo2
{
    public class A2
    {

        public static void Main()
        {
            int m, n;
            Console.WriteLine("Enter 2 numbers");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            if (m > n)
            {
                Console.WriteLine($"{m} is the greater number");
            }
            else if(n > m)
            {
                Console.WriteLine($"{n} is the greater number");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }

        }

    }

}
