namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class SolidIngredient : Ingredient
    {
        public override string Unit()
        {
            return "grams";
        }
    }
}
