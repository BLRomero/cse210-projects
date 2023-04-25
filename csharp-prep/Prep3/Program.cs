using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
    
        int guess = 0;

        while (guess != magicNumber)
        {
            
            Console.Write("Pick a number between 1-100. What is your guess? ");
            guess =  int.Parse(Console.ReadLine());
            
            if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }

            else 
            {
                Console.WriteLine("You Guessed It!!");
            }
        }; 
    }
}

