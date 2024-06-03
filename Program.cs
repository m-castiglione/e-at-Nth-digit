using System;

namespace e_at_Nth_digit;

class Program
{
    const double e = Math.E;
    static void Main(string[] args)
    {
        Console.WriteLine(e);
        Greetings();
        string? userInput = Console.ReadLine();
        Console.WriteLine(PrintDigits(userInput));      
    }

    static void Greetings() 
    {
        Console.WriteLine("Hello! Please enter an integer representing what digit position of e you want printed out!: ");

    }

    static double PrintDigits(string userDigit)
    {    
        int? digit;
        double eToDigit;

        if (int.TryParse(userDigit, out int i)){
            digit = Convert.ToInt32(userDigit);

            eToDigit = Math.Round(e, (int)digit);
        }
        else {
            Console.WriteLine("ERROR: Not an integer");
            return 0;
        }

        return eToDigit;
    }
}
