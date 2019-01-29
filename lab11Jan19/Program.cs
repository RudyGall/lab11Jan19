using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11Jan19
{
    class Program
    {
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to run the application again? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Console.ReadLine();
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
        static void Main(string[] args)
        {
            bool runP = true;
            while (runP == true)
            {
                Movie SciFi1 = new Movie("SciFi1", 1);
                Movie SciFi2 = new Movie("SciFi2", 1);
                Movie SciFi3 = new Movie("SciFi3", 1);
                Movie Ani1 = new Movie("Ani1", 2);
                Movie Ani2 = new Movie("Ani2", 2);
                Movie Dra1 = new Movie("Dra1", 3);
                Movie Dra2 = new Movie("Dra2", 3);
                Movie Hor1 = new Movie("Hor1", 4);
                Movie Hor2 = new Movie("Hor2", 4);
                Movie Hor3 = new Movie("Hor3", 4);

                List<Movie> movieList = new List<Movie>();
                movieList.Add(SciFi1);
                movieList.Add(SciFi2);
                movieList.Add(SciFi3);
                movieList.Add(Ani1);
                movieList.Add(Ani2);
                movieList.Add(Dra1);
                movieList.Add(Dra2);
                movieList.Add(Hor1);
                movieList.Add(Hor2);
                movieList.Add(Hor3);

                int movieCt = movieList.Count;
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("\nThere are {0} movies in this list.", movieCt);
                Console.WriteLine("Select a category: ");
                Console.WriteLine("1: SciFi");
                Console.WriteLine("2: Animated");
                Console.WriteLine("3: Drama");
                Console.WriteLine("4: Horror");
                Console.WriteLine("");
                Console.Write("enter a number 1-4): ");
                int.TryParse(Console.ReadLine(), out int userInt);

                foreach (Movie m in movieList)
                {
                    switch (userInt)
                    {
                        case 1:
                            m.PrintSci();
                            break;
                        case 2:
                            m.PrintAni();
                            break;
                        case 3:
                            m.PrintDra();
                            break;
                        case 4:
                            m.PrintHor();
                            break;
                    }
                }
                runP = Continue();
            }

        }
    }
}