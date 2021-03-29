namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Mix implementing ingredient, timed and speed processes.
    /// </summary>
    internal class Mix : IIngredientProcess, ITimedProcess, ISpeedProcess
    {
        // list of ingredients.//
        private List<Ingredient> ingredients;
        private string mixSpeed;
        private string mixTime;

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Mix()
        {
            this.ingredients = new List<Ingredient>();
        }

        /// <summary>
        /// Name Property
        /// </summary>
        /// <returns> name of method.</returns>
        public string Name()
        {
            return "Mix";
        }

        /// <summary>
        /// gets ingredients list
        /// </summary>
        /// <returns> list of ingredients.</returns>
        public List<Ingredient> GetIngredients()
        {
            return this.ingredients;
        }

        /// <summary>
        /// function to perform the process.
        /// </summary>
        /// <returns></returns>
        public string Perform()
        {
            return ExecuteProcess.PerformProcess(this);
        }

        /// <summary>
        /// function to set the list of ingredients.
        /// </summary>
        /// <param name="ingredients"> list of ingredients.</param>
        public void SetIngredient(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        /// <summary>
        /// function set mix time.
        /// </summary>
        /// <param name="time"></param>
        public void SetTime(string time)
        {
            this.mixTime = time;
        }

        /// <summary>
        /// function to set mix speed.
        /// </summary>
        /// <param name="speed"></param>
        public void SetSpeed(string speed)
        {
            this.mixSpeed = speed;
        }

        /// <summary>
        /// function to get mix speed.
        /// </summary>
        /// <returns></returns>
        public string GetSpeed()
        {
            return this.mixSpeed;
        }

        /// <summary>
        /// function get mix time.
        /// </summary>
        /// <returns></returns>
        public string GetTime()
        {
            return this.mixTime;
        }
    }
}
