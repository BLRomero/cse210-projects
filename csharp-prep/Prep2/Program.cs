using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage: ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string letter = "";


        if (grade >= 90 )
            {
                if (grade >= 93)
                {
                    letter = "A";
                }

                else {
                    letter = "A-";
                }
            }
            else if (grade >= 80)
            {
                 if (grade >= 87)
                    letter = "B+";
                // Console.Write("You earned an A, you have passed the class");
                else if (grade >= 83)
                {
                    letter = "B";
                }

                else {
                    letter = "B-";
                }
                // Console.Write("You earned a B, you have passed the class ");
               
            }
            else if (grade  >= 70)
            {
                 if (grade >= 77)
                    letter = "C+";
                // Console.Write("You earned an A, you have passed the class");
                else if (grade >= 73)
                {
                    letter = "C";
                }

                else {
                    letter = "C-";
                }
                // Console.Write("You earned a C, you have passed the class");
               
            }
            else if (grade >= 60)
            {
                // Console.Write("You earned a D, you have failed the class. You need at least a 70 to pass Good luck next time");
                letter = "D";
            }
            else 
            {
                // Console.Write("You earned an F, You have failed the course. Good luck next time");
                letter = "F";
                
            }     
            Console.WriteLine($"Your grade is: {letter}");
            
            if (grade >= 70)
            {
                Console.WriteLine("You Passed");
            }
            else
            {
                Console.WriteLine("Better Luck Next Time");
            }


            
    }
}