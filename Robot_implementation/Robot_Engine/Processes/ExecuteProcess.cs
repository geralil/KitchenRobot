using System;
using System.Collections.Generic;
using System.Text;

namespace Robot_Engine
{
    internal class ExecuteProcess
    {
        public static string PerformProcess(IProcess process)
        {
            StringBuilder action = new StringBuilder();

            action.Append(process.Name() + " ");
            if (process is IIngredientProcess)
            {
                IIngredientProcess ingredientProcess = process as IIngredientProcess;
                List<Ingredient> ingredients = ingredientProcess.GetIngredients();
                for (int i = 0; i < ingredients.Count; i++)
                {
                    action.Append(ingredients[i].Weight.ToString()).Append(" ").Append(ingredients[i].Unit()).Append(" ");
                    action.Append(ingredients[i].Name).Append(" ");
                }

            }
            if (process is ITimedProcess)
            {
                ITimedProcess timedProcess = process as ITimedProcess;
                action.Append(timedProcess.GetTime().ToString()).Append(" ");
            }
            if (process is ITimedHeatProcess)
            {
                ITimedHeatProcess timedHeatProcess = process as ITimedHeatProcess;
                action.Append("at ").Append(timedHeatProcess.GetTemp().ToString());
            }
            if (process is ISpeedProcess)
            {
                ISpeedProcess speedProcess = process as ISpeedProcess;
                action.Append("at ").Append(speedProcess.GetSpeed());
            }

            return action.ToString();
        }
    }
}
