using System;
using System.Collections.Generic;
using System.Text;

namespace Robot_Engine
{
    internal class Bake : ITimedHeatProcess, IIngredientProcess
    {
        private int temp;
        private string time;
        private List<Ingredient> ingredients;

        public Bake()
        {
            this.ingredients = new List<Ingredient>();
        }

        public List<Ingredient> GetIngredients()
        {
            return this.ingredients;
        }

        public int GetTemp()
        {
            return this.temp;
        }

        public string GetTime()
        {
            return this.time;
        }

        public string Name()
        {
            return "Bake";
        }

        public string Perform()
        {
            return ExecuteProcess.PerformProcess(this);
        }

        public void SetIngredient(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public void SetTemp(int temp)
        {
            this.temp = temp;
        }

        public void SetTime(string time)
        {
            this.time = time;
        }
    }
}
