using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken nuggets", "pizza", "burger", "fries", "salad" };
            
            Console.WriteLine($"COMPUTER PICKED: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
           
            Console.WriteLine($"COMPUTER PICKED: {drinks[GenerateRandomIndex(drinks)]}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Fight club", "Drive", "James Bond" };
           
            Console.WriteLine($"COMPUTER PICKED: {movies[GenerateRandomIndex(movies)]}");
        }
    }
}
