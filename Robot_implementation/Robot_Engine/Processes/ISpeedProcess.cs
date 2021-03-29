namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Interface speed process that denotes processes
    /// that require a speed.
    /// </summary>
    public interface ISpeedProcess : IProcess
    {
        void SetSpeed(string speed);
        string GetSpeed();
    }
}
