namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Soak class inheriting from timed process and ingredient process.
    /// </summary>
    internal class Soak : ITimedProcess, IIngredientProcess
    {
        private List<Ingredient> ingredients;
        private string time;

        public Soak()
        {
            this.ingredients = new List<Ingredient>();
        }

        /// <summary>
        /// function to return list of ingredients.
        /// </summary>
        /// <returns></returns>
        public List<Ingredient> GetIngredients()
        {
            return this.ingredients;
        }

        /// <summary>
        /// Name property returns soak.
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Soak";
        }

        /// <summary>
        /// Perform function to execute process.
        /// </summary>
        /// <returns></returns>
        public string Perform()
        {
            return ExecuteProcess.PerformProcess(this);
        }

        /// <summary>
        /// function to set ingredients.
        /// </summary>
        /// <param name="ingredients"></param>
        public void SetIngredient(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        /// <summary>
        /// function to set time.
        /// </summary>
        /// <param name="time"> soak time.</param>
        public void SetTime(string time)
        {
            this.time = time;
        }

        /// <summary>
        /// function to return the soak time.
        /// </summary>
        /// <returns></returns>
        string ITimedProcess.GetTime()
        {
            return this.time;
        }

    }
}
