using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

            Console.ReadLine();
        }

        private static void ListMovies()
        {
            Movie deadpool3;
            deadpool3.Title = "Deadpool & Wolverine";
            deadpool3.releaseYear = 2025;
            deadpool3.Price = 12.99;
            deadpool3.Rating = MovieRating._15;

            Console.WriteLine(deadpool3.Title += " (" + deadpool3.releaseYear + ") Rated " + deadpool3.Rating);
        }
        private static void ListShows()
        {
            List<TVShow> shows = new List<TVShow>();
            shows.Add(new TVShow("The Lord of theRings: The Rings of Power", 2022, 0, MovieRating._15));
            shows.Add(new TVShow("The Boys", 2019, 7.99, MovieRating._18));
            shows.Add(new TVShow("Ben and Holly's Little Kingdom", 2009, 12.45, MovieRating._U));

            for (int i = 0; i < shows.Count; i++)
            {
                Console.WriteLine(shows[i].ToString());
            }
        }

        private static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please choose from the following options: \n");
                Console.WriteLine("(1) List Movies");
                Console.WriteLine("(2) List TVShows");
                Console.WriteLine("\n");
                Console.WriteLine("(0) Exit Application");
                Console.WriteLine("\n");

                string userInput = Console.ReadLine();

                if(int.TryParse(userInput, out int integerInput))
                {
                    switch (integerInput)
                    {
                        case 0:
                            Enviroment.Exit(0);
                            break;
                        case 1:
                            ListMovies();
                            Console.ReadKey();
                            break;
                        case 2:
                            ListShows();
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
        public enum MovieRating
        {
            _U,
            _12A,
            _12,
            _15,
            _18
        }

        public struct Movie
        {
            public string Title;
            public int releaseYear;
            public double Price;
            public MovieRating Rating;
        }









