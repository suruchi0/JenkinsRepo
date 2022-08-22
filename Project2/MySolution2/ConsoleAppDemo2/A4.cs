namespace ConsoleAppDemo2
{
    public class A4
    {
        public static void Main()
        {
            string str, str1;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            int n = str.Length;

            Console.Write($"{str.Substring(n - 1)}{str.Substring(1, n - 2)}{str.Substring(0,1)}");
        }

    }

}