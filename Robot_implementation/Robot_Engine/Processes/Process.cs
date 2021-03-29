using System;
using System.Collections.Generic;
using System.Text;

namespace Robot_Engine
{
    public interface IProcess
    {
        string Name();
        string Perform();
    }
}
