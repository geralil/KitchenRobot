namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class LetRest that inherits from timed process.
    /// </summary>
    internal class LetRest : ITimedProcess
    {
        private string time;

        public string GetTime()
        {
            return this.time;
        }

        public string Name()
        {
            return "Let Rest";
        }

        public string Perform()
        {
            return ExecuteProcess.PerformProcess(this);
        }

        public void SetTime(string time)
        {
            this.time = time;
        }
    }
}
