namespace Kitchen_Robot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Robot_Engine;

    /// <summary>
    /// Class to initialize a robot of class StewHelper and perform its functionalities.
    /// </summary>
    internal class InitializeStewHelper
    {
        private Robot robot1;
        public InitializeStewHelper()
        {
            this.robot1 = new Robot("StewHelper", 10);
            this.robot1.LabelContainer("Chickpeas");
            this.robot1.LabelContainer("Celery");
            this.robot1.LabelContainer("Water");
            this.robot1.LabelContainer("Salt");
            this.robot1.LabelContainer("DicedTomatoes");
            this.robot1.LabelContainer("DicedCarrots");
            this.robot1.LabelContainer("Sugar");
            this.AddPreDefinedChickPeaSoupRecipe();
        }

        /// <summary>
        /// Function to add a predefined recipe to make chickpea soup.
        /// </summary>
        public void AddPreDefinedChickPeaSoupRecipe()
        {
            List<string> recipe = new List<string>();
            List<string> recipeIngredients = new List<string>();
            recipeIngredients.Add("Chickpeas 200");
            recipeIngredients.Add("Water 900");
            recipeIngredients.Add("Celery 100");
            recipeIngredients.Add("DicedTomatoes 200");
            recipeIngredients.Add("DicedCarrots 200");

            recipe.Add("Soak Chickpeas for 8 h");
            recipe.Add("Empty");
            recipe.Add("Add Water Celery DicedTomatoes DicedCarrots");
            recipe.Add("Cook for 1 h");

            robot1.InitializeNewRecipe("Make Chickpea Soup");
            robot1.AddRecipeIngredients("Make Chickpea Soup", recipeIngredients);
            robot1.AddRecipeSteps("Make Chickpea Soup", recipe);
        }

        /// <summary>
        /// function to add new recipe to the robot.
        /// </summary>
        public void AddNewRecipe()
        {
            PerformClientFunctions.AddNewRecipe(this.robot1);
        }

        /// <summary>
        /// function to execute recipe.
        /// </summary>
        /// <param name="recipeName"></param>
        public void ExecuteRecipe(string recipeName)
        {
            PerformClientFunctions.ExecuteRecipe(recipeName, this.robot1);
        }

        /// <summary>
        /// function to add ingredient containers.
        /// </summary>
        /// <param name="ingredientName"></param>
        public void AddContainers(string ingredientName)
        {
            PerformClientFunctions.AddContainers(ingredientName, this.robot1);
        }

        /// <summary>
        /// Function to update containers with new labels
        /// </summary>
        /// <param name="oldContainerName"></param>
        /// <param name="newContainerName"></param>
        public void UpdateContainer(string oldContainerName, string newContainerName)
        {
            PerformClientFunctions.UpdateContainer(oldContainerName, newContainerName, this.robot1);
        }
    }
}
