namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IIngredient interface inheriting from Iprocess.
    /// Denotes processes that use a list of ingredients.
    /// </summary>
    public interface IIngredientProcess : IProcess
    {
        // function to set list of ingredients.//
        void SetIngredient(List<Ingredient> ingredients);

        // function to get list of ingredients.//
        List<Ingredient> GetIngredients();
    }
}
