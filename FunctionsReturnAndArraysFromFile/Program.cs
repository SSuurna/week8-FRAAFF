using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken nuggets", "pizza", "burger", "fries", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);
            string randomFood = foods[randomIndex];
            Console.WriteLine($"COMPUTER PICKED: {randomFood}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);
            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"COMPUTER PICKED: {randomDrink}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Fight club", "Drive", "James Bond" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);
            string randomMovie = movies[randomIndex];
            Console.WriteLine($"COMPUTER PICKED: {randomMovie}");
        }
    }
}
