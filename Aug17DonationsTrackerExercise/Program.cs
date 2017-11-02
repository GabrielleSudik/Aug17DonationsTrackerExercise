using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug17DonationsTrackerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            string email;
            int fiscYear = 2017;

            double ones;
            double fives;
            double tens;
            double twenties;
            double fifties;
            double hundreds;
            double quarters;

            Console.WriteLine("Hello, donor. Thanks for your support!");
            Console.WriteLine("Before you make your donation, let's collect some info from you.");

            Console.WriteLine("\nWhat's your name?");
            name = Console.ReadLine();

            Console.WriteLine("\nWhere do you live?");
            city = Console.ReadLine();

            Console.WriteLine("\nWhat's your email?");
            email = Console.ReadLine();

            Console.WriteLine("\nHow many ones will you donate?");
            ones = double.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many fives will you donate?");
            fives = double.Parse(Console.ReadLine()); 

            Console.WriteLine("How many tens will you donate?");
            tens = double.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many twenties will you donate?");
            twenties = double.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many fifties will you donate?");
            fifties = double.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many hundreds will you donate?");
            hundreds = double.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many quarters will you donate?");
            quarters = double.Parse(Console.ReadLine());

            double totalOnes = ones * 1;
            double totalFives = fives * 5;
            double totalTens = tens * 10;
            double totalTwenties = twenties * 20;
            double totalFifties = fifties * 50;
            double totalHundreds = hundreds * 100;
            double totalQuarters = quarters * .25;

            double totalDonation = (totalOnes + totalFives + totalTens +
                totalTwenties + totalFifties + totalHundreds + totalQuarters);

            Console.WriteLine($"\nThank you, {name}. Here is your receipt:\n");
            Console.WriteLine($"Address: {city}. Email: {email}. Year: {fiscYear}.");
            Console.WriteLine($"Total donation: {totalDonation}. Thank you!");

            //this is added to practice working on branches in GitHub:

            Console.WriteLine("Hello, World! It's November 1, 2017.");

            Console.WriteLine("This too, but I'm going to uncheck this line in GitHub, to see if it saves...");
            Console.ReadLine();
        }
    }
}
