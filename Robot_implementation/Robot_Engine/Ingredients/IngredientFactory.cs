namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;

    /// <summary>
    /// Ingredient factory that generates the required type of ingredient.
    /// </summary>
    public static class IngredientFactory
    {
        public static Ingredient Create(string ingredientName, double ingredientWeight)
        {
            Type type = Type.GetType("Robot_Engine." + ingredientName);

            if (type != null)
            {
                Ingredient ingredient = (Ingredient)Activator.CreateInstance(type);
                ingredient.Weight = ingredientWeight;

                return ingredient;
            }
            return null;
        }
    }
}
