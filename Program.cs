using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfPets = 3;
            const int numberOfPeople = 2;
            double dogAgeOne = 8.5;
            double dogAgeTwo = 6.5;
            string namesOfHumans = "Stephen and Misha";
            char exclaimSymbol = '!';
            bool nextPetAdopt = false;
            //numberOfPets = 4; removed because of build error due to const variable 

            Console.WriteLine("Along with " + namesOfHumans + " there are " + (numberOfPets + numberOfPeople) + " members of their household");
            Console.ReadKey();
            Console.WriteLine(namesOfHumans + " have two dogs ages " + dogAgeOne + " and " + dogAgeTwo);
            Console.ReadKey();
            Console.WriteLine("Their combined age is " + (dogAgeOne + dogAgeTwo) + exclaimSymbol);
            Console.ReadKey();
            Console.WriteLine(namesOfHumans + " want to adopt another dog but can theyy\b?\n\t" + nextPetAdopt);

        }
    }
}
