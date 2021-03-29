namespace Kitchen_Robot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Robot_Engine;

    /// <summary>
    /// Class that initializes and contains a robot of type baker helper.
    /// </summary>
    internal class InitializeBakerHelper
    {
        private Robot robot1;
        public InitializeBakerHelper()
        {
            robot1 = new Robot("BakerHelper", 8);
            robot1.LabelContainer("Flour");
            robot1.LabelContainer("Starter");
            robot1.LabelContainer("Sugar");
            robot1.LabelContainer("Water");
            robot1.LabelContainer("Salt");
            this.AddPreDefinedSourDoughRecipe();
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
        /// function to update ingredient containers with new ingredients.
        /// </summary>
        /// <param name="oldContainerName"></param>
        /// <param name="newContainerName"></param>
        public void UpdateContainer(string oldContainerName, string newContainerName)
        {
            PerformClientFunctions.UpdateContainer(oldContainerName, newContainerName, this.robot1);
        }

        /// <summary>
        /// function add a predefined recipe to make Sour Dough.
        /// </summary>
        public void AddPreDefinedSourDoughRecipe()
        {
            List<string> recipe = new List<string>();
            List<string> recipeIngredients = new List<string>();
            recipeIngredients.Add("Flour 500");
            recipeIngredients.Add("Water 400");
            recipeIngredients.Add("Salt 10");
            recipeIngredients.Add("Starter 100");

            recipe.Add("Mix Flour Water at low speed for 1 min");
            recipe.Add("LetRest for 1 h");
            recipe.Add("Mix Dough Salt and Starter at low speed for 1 min");
            recipe.Add("Pause 30 min");
            recipe.Add("Mix Dough at low speed for 1 min");
            recipe.Add("Pause 30 min");
            recipe.Add("Mix Dough at low speed for 1 min");
            recipe.Add("Pause 30 min");
            recipe.Add("Mix Dough at low speed for 1 min");
            recipe.Add("Pause 30 min");
            recipe.Add("Bake Dough 20 min at 500");
            recipe.Add("Bake Dough 25 min at 450");

            robot1.InitializeNewRecipe("Make Sourdough");
            robot1.AddRecipeIngredients("Make Sourdough", recipeIngredients);
            robot1.AddRecipeSteps("Make Sourdough", recipe);
        }

        /// <summary>
        /// function to add predefined recipe to make cake.
        /// </summary>
        public void AddPreDefinedCakeRecipe()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// function to add new recipe to the robot class.
        /// </summary>
        public void AddNewRecipe()
        {
            PerformClientFunctions.AddNewRecipe(this.robot1);
        }

        /// <summary>
        /// function to execute recipe passed in as recipe name.
        /// </summary>
        /// <param name="recipeName"></param>
        public void ExecuteRecipe (string recipeName)
        {
            PerformClientFunctions.ExecuteRecipe(recipeName, this.robot1);
        }
    }
}
