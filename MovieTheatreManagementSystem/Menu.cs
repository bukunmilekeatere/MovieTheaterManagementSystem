using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreManagementSystem
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie Theater System");
            Console.WriteLine();
            DisplayMainMenu();
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Manage Movies");
            Console.WriteLine("2. Manage Theaters");
            Console.WriteLine("3. Manage Venues");
            Console.WriteLine("4. Search for Movies in a Specific Theater");
            Console.WriteLine("5. Search for Venues that have showtimes for a Specific Movie [BONUS]");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.WriteLine("Please enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ManageMovies();
                        break;
                    case 2:
                        ManageTheaters();
                        break;
                    case 3:
                        ManageVenues();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Please enter a number.");
            }
        }

        static void ManageMovies()
        {
            while (true)
            {
                MovieTheatreManagementSystem.ManageMoviesMenu.DisplayMovieMenu();

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            MovieTheatreManagementSystem.ManageMoviesMenu.AddNewMovie();
                            break;
                        case 2:
                            MovieTheatreManagementSystem.ManageMoviesMenu.RemoveMovie();
                            break;
                        case 3:
                            MovieTheatreManagementSystem.ManageMoviesMenu.UpdateMovieDetails();
                            break;
                        case 4:
                            MovieTheatreManagementSystem.ManageMoviesMenu.ViewAllMovies();
                            break;
                        case 5:
                            MainMenu(); // Go back to the main menu
                            break;
                        default:
                            Console.WriteLine("Invalid enter an option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid enter a number.");
                }
            }
        }

        static void MainMenu()
        {
            Console.Clear();

            DisplayMainMenu();
        }



        static void ManageTheaters()
        {
            while (true)
            {
                MovieTheatreManagementSystem.ManageTheaterMenu.DisplayTheaterMenu();

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            MovieTheatreManagementSystem.ManageTheaterMenu.AddNewTheater();
                            break;
                        case 2:
                            MovieTheatreManagementSystem.ManageTheaterMenu.RemoveTheater();
                            break;
                        case 3:
                            MovieTheatreManagementSystem.ManageTheaterMenu.UpdateTheaterDetails();
                            break;
                        case 4:
                            MovieTheatreManagementSystem.ManageTheaterMenu.ViewAllTheaters();
                            break;
                        case 5:
                            MainMenu(); // Go back to the main menu
                            break;
                        default:
                            Console.WriteLine("Invalid enter an option.");
                            break;
                    }
                }

            }

        }

        static void ManageVenues()
        {
            Console.WriteLine("");

        }
        }
    }
