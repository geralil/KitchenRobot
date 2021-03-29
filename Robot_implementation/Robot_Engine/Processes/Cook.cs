namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class cook that inherits from timed heating process.
    /// </summary>
    internal class Cook : ITimedHeatProcess
    {
        private int temp;
        private string time;

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
            return "Cook";
        }

        public string Perform()
        {
            return ExecuteProcess.PerformProcess(this);
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
