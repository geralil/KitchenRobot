namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Process Factory class that generates a process of the
    /// type of name of process and add the necessary fields to the process
    /// based on the type.
    /// </summary>
    public static class ProcessFactory
    {
        /// <summary>
        /// Function to generate the generic process object.
        /// </summary>
        /// <param name="stepElements"></param>
        /// <param name="recipeIngredients"></param>
        /// <returns> Iprocess object.</returns>
        public static IProcess CreateGenericProcess(string[] stepElements, ref Dictionary<string, Ingredient> recipeIngredients)
        {
            Type type = Type.GetType("Robot_Engine." + stepElements[0]);
            IProcess newProcess = (IProcess)Activator.CreateInstance(type);
            List<Ingredient> ingredients = new List<Ingredient>();

            for (int i = 1; i < stepElements.Length; i++)
            {
                // if array of strings contains ingredients.//
                if (recipeIngredients.ContainsKey(stepElements[i]))
                {
                    IIngredientProcess ingredientProcess = newProcess as IIngredientProcess;

                    ingredients.Add(recipeIngredients[stepElements[i]]);

                    ingredientProcess.SetIngredient(ingredients);
                    newProcess = ingredientProcess;
                    continue;
                }
                // if array of strings contains speed.//
                if (stepElements[i] == "speed")
                {
                    ISpeedProcess speedProcess = newProcess as ISpeedProcess;
                    string speed = stepElements[i - 1] + stepElements[i];
                    speedProcess.SetSpeed(speed);
                    newProcess = speedProcess;
                    continue;
                }
                // if array of string contains time.//
                if (stepElements[i] == "h" || stepElements[i] == "min" || stepElements[i] == "seconds")
                {
                    ITimedProcess timedProcess = newProcess as ITimedProcess;
                    string time = stepElements[i - 1] + stepElements[i];
                    timedProcess.SetTime(time);
                    newProcess = timedProcess;
                    continue;
                }
                // if process is of type ItimedHeatProcess.//
                if (newProcess is ITimedHeatProcess)
                {
                    ITimedHeatProcess timedHeatProcess = newProcess as ITimedHeatProcess;
                    int temp;
                    if (int.TryParse(stepElements[i], out temp))
                    {
                        timedHeatProcess.SetTemp(temp);
                    }
                }
            }
            // return the process.//
            return newProcess;
        }
    }
}
