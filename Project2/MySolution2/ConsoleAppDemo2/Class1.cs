namespace ConsoleAppDemo2
{
    public class A3
    {
        public static void Main()
        {
            int count = 0;
            string str;
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                    count++;
            }
            Console.WriteLine($"The number of vowels is {count}");
    
        }

    }

}
