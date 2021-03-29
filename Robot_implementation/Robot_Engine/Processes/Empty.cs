using System;
using System.Collections.Generic;
using System.Text;

namespace Robot_Engine
{
    internal class Empty : IProcess
    {
        public string Name()
        {
            return "Empty";
        }

        public string Perform()
        {
            return ExecuteProcess.PerformProcess(this);
        }
    }
}
