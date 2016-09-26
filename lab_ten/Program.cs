using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_ten
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont;
            List<string> listOfMovieTitles = new List<string>();

            displayTitle();

            do
            {
                int userChoice = chooseCategory();

                listOfMovieTitles = makeCategoryList(userChoice);

                displaySortedList(listOfMovieTitles);

                Console.Write("\n\nContinue?(y/n):\t");
                cont = Console.ReadLine();
            } while (cont.ToLower() == "y");
        }

        static void displayTitle()
        {
            Console.Write("Welcome to the Movie List Application!");
        }

        static int chooseCategory()
        {
            int userChoice;

            do
            {
                Console.Write("\n\nThere are " + MovieIO.default_MovieCatalog.Count.ToString() + " movies in this list.");
                Console.Write("\nWhat category are you interested in?");
                Console.Write("\n\n1)Animated\n2)Drama\n3)Horror\n4)SciFi\n5)Musical\n6)Comedy\n\nPlease enter 1-6...\t");
                bool result = Int32.TryParse(Console.ReadLine(), out userChoice);

                if (userChoice < 1 || userChoice > 6)
                    Console.Write("\n\n<---Error--->Invalid Choice, Please Try Again...");
            } while (userChoice < 1 || userChoice > 6);

            return userChoice;
        }

        static List<String> makeCategoryList(int userChoice)
        {
            List<String> movieList = new List<String>();

            foreach (Movie movie in MovieIO.default_MovieCatalog)
            {
                if(userChoice == 1)
                {
                    if(movie.Category.ToLower() == "animated")
                        movieList.Add(movie.Title);
                }
                else if(userChoice == 2)
                {
                    if(movie.Category.ToLower() == "drama")
                        movieList.Add(movie.Title);
                }
                else if(userChoice == 3)
                {
                    if (movie.Category.ToLower() == "horror")
                        movieList.Add(movie.Title);
                }
                else if(userChoice == 4)
                {
                    if (movie.Category.ToLower() == "scifi")
                        movieList.Add(movie.Title);
                }
                else if(userChoice == 5)
                {
                    if (movie.Category.ToLower() == "musical")
                        movieList.Add(movie.Title);
                }
                else if( userChoice == 6)
                {
                    if (movie.Category.ToLower() == "comedy")
                        movieList.Add(movie.Title);
                }
            }

            return movieList;
        }

        static void displaySortedList(List<string> listOfMovies)
        {
            listOfMovies.Sort();

            foreach (string movie in listOfMovies)
                Console.Write("\n" + movie);
        }
    }
}
