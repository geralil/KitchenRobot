namespace Kitchen_Robot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Robot_Engine;

    /// <summary>
    /// Class program that acts as the starting point of application.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            InitializeBakerHelper bakerHelper = new InitializeBakerHelper();
            InitializeStewHelper stewHelper = new InitializeStewHelper();

            Console.Clear();
            int option = DisplayMenu();

            if (option == 1)
            {
                DisplayBakerHelperRobotMenu(bakerHelper);
            }

            if (option == 2)
            {
                DisplayStewHelperRobotMenu(stewHelper);
            }
        }

        /// <summary>
        /// method to display the stew helper robot menu.
        /// </summary>
        /// <param name="stewHelper"></param>
        private static void DisplayStewHelperRobotMenu(InitializeStewHelper stewHelper)
        {
            int option = 0;

            while (option != 4)
            {
                Console.Clear();
                option = DisplayRobotMenu();

                switch (option)
                {
                    case 1:
                        stewHelper.AddNewRecipe();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("\nEnter old container name: ");
                        string oldContainerName = Console.ReadLine();
                        Console.WriteLine("\nEnter new container name: ");
                        string newContainerName = Console.ReadLine();
                        stewHelper.UpdateContainer(oldContainerName, newContainerName);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("\nEnter name of recipe: ");
                        string recipeName = Console.ReadLine();
                        stewHelper.ExecuteRecipe(recipeName);
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
            
        }

        /// <summary>
        /// function to display the menu items.
        /// </summary>
        /// <returns></returns>
        private static int DisplayRobotMenu()
        {
            Console.WriteLine("Option are: ");
            Console.WriteLine("1. Add Custom Recipes to robot.");
            Console.WriteLine("2. Edit Container Label.");
            Console.WriteLine("3. Execute Recipe.");
            Console.WriteLine("4. Exit.");
            Console.WriteLine("Select option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            return option;
        }

        /// <summary>
        /// method to display the baker helper robot menu.
        /// </summary>
        /// <param name="bakerHelper"></param>
        private static void DisplayBakerHelperRobotMenu(InitializeBakerHelper bakerHelper)
        {
            int option = 0;

            while (option != 4)
            {
                Console.Clear();
                option = DisplayRobotMenu();

                switch (option)
                {
                    case 1:
                        bakerHelper.AddNewRecipe();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("\nEnter old container name: ");
                        string oldContainerName = Console.ReadLine();
                        Console.WriteLine("\nEnter new container name: ");
                        string newContainerName = Console.ReadLine();
                        bakerHelper.UpdateContainer(oldContainerName, newContainerName);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("\nEnter name of recipe: ");
                        string recipeName = Console.ReadLine();
                        bakerHelper.ExecuteRecipe(recipeName);
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// function to use menu to choose between the 2 robots.
        /// </summary>
        /// <returns></returns>
        private static int DisplayMenu()
        {
            Console.WriteLine("Which robot would you like to select? 1.BakerHelper 2.StewHelper");
            Console.Write("\nEnter option (1/2): ");
            int option = Convert.ToInt32(Console.ReadLine());

            return option;
        }
    }
}
