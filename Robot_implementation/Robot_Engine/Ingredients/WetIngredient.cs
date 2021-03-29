using System;
using System.Collections.Generic;
using System.Text;

namespace Robot_Engine
{
    public abstract class WetIngredient : Ingredient
    {
        public override string Unit()
        {
            return "ml";
        }
    }
}
