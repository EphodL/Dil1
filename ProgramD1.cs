using System;
namespace Deliverable__1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter an integer number between 1 and 100: ");
            int input = ReadIntegerInput();

            Console.Write("Specify the series type: Even or Odd");
            string series = Console.ReadLine();

            if (series.ToLower() == "Even")
            {
                Console.WriteLine("You have selected the {series} series. The numbers between 0 and {input} are:");
                for (int i = 0; i <= input; i = i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            else if (series.ToLower() == "Odd")
            {
                Console.WriteLine("You have selected the {series} series. The number between 0 and {input} are:");
                for (int i = 1; i <= input; i = i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid series type specified. Please choose one of two options 'Even' or 'Odd'.");
            }
        }
        static int ReadIntegerInput()
        {
            int input;
            while (true)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input >= 1 && input <= 100)
                    {
                        return input;
                    }
                    else
                    {
                        Console.Write("Please enter an integer between 1 and 100: ");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Invalid input. Please enter an integer: ");
                }
            }
        }
    }
}
