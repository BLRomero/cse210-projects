using System;

class Program
{
    static void Main(string[] args)
    {
         // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
       
        int userNumber = -1;
        
    
        while (userNumber != 0)
        { 
            Console.Write("Enter a number, type 0 when finished.");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0) {
                numbers.Add(userNumber);
            }
        }
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
        
    }
    Console.WriteLine($"The sum is: {sum}");
    
    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is : {average}");

    int max = numbers[0];
    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }
    Console.WriteLine($"The largest number is: {max}");

    int smallest = numbers[0];
    foreach (int number in numbers)
    {
        if (number < smallest && number > 0 )
        {
            smallest = number;
        }
    }
    Console.WriteLine($"The smallest number is: {smallest}");

  
    }
}