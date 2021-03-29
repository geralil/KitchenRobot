namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Recipe class that stores information about one recipe
    /// for a robot.
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Dictionary of available ingredients.
        /// </summary>
        private Dictionary<string, Ingredient> availableIngredients;

        /// <summary>
        /// Dictionary of ingredients in recipe.
        /// </summary>
        private Dictionary<string, Ingredient> recipeIngredients;

        private string name;
        private StringBuilder process;

        /// <summary>
        /// queue of processes.
        /// </summary>
        private Queue<IProcess> processes;

        /// <summary>
        /// Constructor for recipe class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="containers"></param>
        public Recipe(string name, ref Dictionary<string, Ingredient> containers)
        {
            this.name = name;
            this.availableIngredients = containers;
            this.process = new StringBuilder();
            this.processes = new Queue<IProcess>();
            this.recipeIngredients = new Dictionary<string, Ingredient>();
        }

        /// <summary>
        /// function to add given process to the queue.
        /// </summary>
        /// <param name="process"></param>
        private void AddProcessToQueue(IProcess process)
        {
            this.processes.Enqueue(process);
        }

        /// <summary>
        /// function to add recipe step passed in as a string.
        /// function decodes the string to generate objects of processes.
        /// </summary>
        /// <param name="recipeStep"></param>
        public void AddRecipeStep(string recipeStep)
        {
            string[] stepElements = recipeStep.Split(' ');
            IProcess newProcess = ProcessFactory.CreateGenericProcess(stepElements, ref this.recipeIngredients);

            this.AddProcessToQueue(newProcess);
        }

        /// <summary>
        /// function to add recipe ingredient to the dictionary.
        /// </summary>
        /// <param name="ingredientName"></param>
        /// <param name="weight"></param>
        public void AddRecipeIngredient(string ingredientName, double weight)
        {
            if (this.availableIngredients.ContainsKey(ingredientName))
            {
                Ingredient newIngredient = IngredientFactory.Create(ingredientName, weight);
                this.recipeIngredients.Add(ingredientName, newIngredient);
            }
            else
            {
                throw new NotSupportedException("Ingredient not available in containers.");
            }
        }

        /// <summary>
        /// function to dequeue from queue and perform the process.
        /// </summary>
        /// <returns></returns>
        public StringBuilder ExecuteRecipe()
        {
            while (processes.Count != 0)
            {
                IProcess process = processes.Dequeue();
                this.process.Append(process.Perform()).Append(Environment.NewLine);
            }
            return this.process;
        }
    }
}