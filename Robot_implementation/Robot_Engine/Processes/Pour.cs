namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class pour inheriting from ingredient process.
    /// </summary>
    internal class Pour : IIngredientProcess
    {
        // list of ingredients to pour.//
        private List<Ingredient> ingredients;

        public Pour()
        {
            this.ingredients = new List<Ingredient>();
        }

        public List<Ingredient> GetIngredients()
        {
            return this.ingredients;
        }

        public string Name()
        {
            return "Pour";
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
