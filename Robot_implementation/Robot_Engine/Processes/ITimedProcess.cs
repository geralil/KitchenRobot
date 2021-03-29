namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ITimedProcess : IProcess
    {
        void SetTime(string time);
        string GetTime();
    }
}
