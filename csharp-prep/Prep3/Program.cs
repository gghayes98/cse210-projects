using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int numGuesses = 1;

            Console.Write("What is the magic number? ");
            guess = Convert.ToInt32(Console.ReadLine());

            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                    Console.WriteLine("Higher");
                else if (guess > magicNumber)
                    Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                numGuesses++;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {numGuesses} guesses.");

            Console.Write("Do you want to play again (yes/no)? ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing!");
    }
}