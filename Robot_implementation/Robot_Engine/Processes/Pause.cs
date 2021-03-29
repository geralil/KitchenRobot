using System;
using System.Collections.Generic;
using System.Text;

namespace Robot_Engine
{
    internal class Pause : ITimedProcess
    {
        private string waitTime;
        public string GetTime()
        {
            return this.waitTime;
        }

        public string Name()
        {
            return "Pause";
        }

        public string Perform()
        {
            return ExecuteProcess.PerformProcess(this);
        }

        public void SetTime(string time)
        {
            this.waitTime = time;
        }
    }
}
