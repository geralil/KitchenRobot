namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Add that inherits from ingredient process.
    /// </summary>
    internal class Add : IIngredientProcess
    {
        private List<Ingredient> ingredients;

        public List<Ingredient> GetIngredients()
        {
            return this.ingredients;
        }

        public string Name()
        {
            return "Add";
        }

        public string Perform()
        {
            return ExecuteProcess.PerformProcess(this);
        }

        public void SetIngredient(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }
    }
}
