using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot_Engine;

namespace Kitchen_Robot
{
    internal class PerformClientFunctions
    {
        public static void AddNewRecipe(Robot robot1)
        {
            Console.Clear();

            string recipeName = string.Empty;
            List<string> recipe = new List<string>();
            List<string> recipeIngredients = new List<string>();
            char answer = 'Y';

            Console.WriteLine("Enter Recipe Name: ");
            recipeName = Console.ReadLine();

            while (answer == 'Y' || answer == 'y')
            {
                Console.WriteLine("\nEnter Ingredients[space]Weight: ");
                recipeIngredients.Add(Console.ReadLine());
                Console.WriteLine("\nMore Ingredients? (Y/N): ");
                answer = Convert.ToChar(Console.ReadLine());
            }
            answer = 'Y';
            while (answer == 'Y' || answer == 'y')
            {
                Console.WriteLine("\nEnter the process and ingredients used as 'Process[space]ingredient[space](s)/time/speed/temperature of Process: ");
                recipe.Add(Console.ReadLine());
                Console.WriteLine("\nMore Steps? (Y/N): ");
                answer = Convert.ToChar(Console.ReadLine());
            }
            robot1.InitializeNewRecipe(recipeName);
            robot1.AddRecipeIngredients(recipeName, recipeIngredients);
            robot1.AddRecipeSteps(recipeName, recipe);
        }

        public static void ExecuteRecipe(string recipeName, Robot robot1)
        {
            StringBuilder recipeAction = robot1.ExecuteRecipe(recipeName);
            Console.Write(recipeAction);
        }

        public static void AddContainers(string ingredientName, Robot robot1)
        {
            robot1.LabelContainer(ingredientName);
        }

        public static void UpdateContainer(string oldContainerName, string newContainerName, Robot robot1)
        {
            robot1.UpdateLabelContainer(oldContainerName, newContainerName);
        }

    }
}
