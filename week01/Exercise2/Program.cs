using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);

        if (percentage >= 90)
            Console.WriteLine("Your grade is A.");
        else if (percentage >= 80)
            Console.WriteLine("Your grade is B.");
        else if (percentage >=70)
            Console.WriteLine("Your grade is C.");
        else if (percentage >= 60)
            Console.WriteLine("Your grade is D.");
        else if (percentage < 60)
            Console.WriteLine("Your grade is F.");
            
    }
}