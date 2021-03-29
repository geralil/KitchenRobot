namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Ingredient
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public abstract string Unit();
    }
}
