using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        int grade = Convert.ToInt32(Console.ReadLine());
        string letterGrade = " ";

        if (grade >= 90)
            letterGrade = "A";
        else if (grade >= 80)
            letterGrade = "B";
        else if (grade >= 70)
            letterGrade = "C";
        else if (grade >= 60)
            letterGrade = "D";
        else
            letterGrade = "F";

        if (grade % 10 >= 7 && grade < 90 && grade >= 60)
            letterGrade += "+";
        else if (grade % 10 < 3 && grade >= 60)
            letterGrade += "-";

        Console.WriteLine($"Your final letter grade is {letterGrade}");
        if (grade >= 70)
            Console.WriteLine("Congratulations, you passed!");
        else
            Console.WriteLine("Unfortunately, you failed. Better luck next time.");
    }
}