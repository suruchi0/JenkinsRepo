class MyClass
{
    enum Grade { Pass = 60, Distinction = 85};
    public static string GetGrade(int mark)
    {
        if (mark >= (int)Grade.Distinction)
            return "Distinction";
        else if (mark >= (int)Grade.Pass)
            return "Pass";
        else
            return "Fail";
    }
    public static void Main()
    {
        int empid;
        int mark;
        Console.WriteLine("Enter Your Employe ID");
        empid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Welcome Employee {empid}");
        Console.WriteLine("Enter Your Score");
        mark = Convert.ToInt32(Console.ReadLine());
        string grade = GetGrade(mark);
        Console.WriteLine($"The Grade is {grade}");

    }
}