namespace Robot_Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ITimedHeatProcess : ITimedProcess
    {
        void SetTemp(int temp);
        int GetTemp();
    }
}
