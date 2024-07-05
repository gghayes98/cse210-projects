using Learning04;
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment _assign = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(_assign.GetSummary());

        MathAssignment _mathA = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(_mathA.GetSummary());
        Console.WriteLine(_mathA.GetHomeworkList());

        WritingAssignment _writingA = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(_writingA.GetSummary());
        Console.WriteLine(_writingA.GetWritingInformation());
    }
}