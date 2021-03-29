namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Robot Class that implements a kitchen robot.
    /// Each robot instance will contain a list of containers
    /// and recipes.
    /// </summary>
    public class Robot
    {
        // name of robot.//
        private string robotName;

        // Dictionary of ingredients objects.//
        private Dictionary<string, Ingredient> containers;

        // Dictionary of recipe objects.//
        private Dictionary<string, Recipe> recipes;

        /// <summary>
        /// Constructor for robot class.
        /// </summary>
        /// <param name="name"> name of robot.</param>
        /// <param name="containerNumber"> number of containers.</param>
        public Robot(string name, int containerNumber)
        {
            this.robotName = name;
            this.containers = new Dictionary<string, Ingredient>(containerNumber);
            this.recipes = new Dictionary<string, Recipe>();
        }

        /// <summary>
        /// Function to label containers.
        /// </summary>
        /// <param name="containerName"> name of label.</param>
        public void LabelContainer (string containerName)
        {
            this.containers.Add(containerName, IngredientFactory.Create(containerName, 200));
        }

        /// <summary>
        /// Replace an existing container label.
        /// </summary>
        /// <param name="oldContainerName"> old container name.</param>
        /// <param name="newContainerName"> new container name.</param>
        public void UpdateLabelContainer (string oldContainerName, string newContainerName)
        {
            this.containers.Remove(oldContainerName);
            this.LabelContainer(newContainerName);
        }

        /// <summary>
        /// Function to initialize and add a new recipe to the dictionary.
        /// </summary>
        /// <param name="recipeName"> name of recipe.</param>
        public void InitializeNewRecipe(string recipeName)
        {
            Recipe newRecipe = new Recipe(recipeName, ref containers);
            this.recipes.Add(recipeName, newRecipe);
        }

        /// <summary>
        /// Function to add recipe ingredients.
        /// </summary>
        /// <param name="recipeName"> name of recipe.</param>
        /// <param name="ingredients"> list of ingredients.</param>
        public void AddRecipeIngredients (string recipeName, List<string> ingredients)
        {
            foreach (var item in ingredients)
            {
                string[] ingredientElements = item.Split(' ');
                double weight;
                double.TryParse(ingredientElements[1], out weight);
                this.recipes[recipeName].AddRecipeIngredient(ingredientElements[0], weight);
            }
        }

        /// <summary>
        /// Function to add steps to a recipe.
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="recipeSteps"> list of steps for the recipe.</param>
        public void AddRecipeSteps (string recipeName, List<string> recipeSteps)
        {
            if (this.recipes.ContainsKey(recipeName))
            {
                for (int i = 0; i < recipeSteps.Count; i++)
                {
                    this.recipes[recipeName].AddRecipeStep(recipeSteps[i]);
                }
            }
            else
            {
                throw new NotSupportedException("Recipe not initialized.");
            }
        }

        /// <summary>
        /// function to execute a given existing recipe.
        /// </summary>
        /// <param name="recipeName"> name of recipe to execute.</param>
        /// <returns></returns>
        public StringBuilder ExecuteRecipe(string recipeName)
        {
            StringBuilder recipe = this.recipes[recipeName].ExecuteRecipe();
            return recipe;
        }
    }
}
