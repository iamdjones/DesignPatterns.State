using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Structure
{
    public class Context
    {
        public State State { get; set; }

        public void Request()
        {
            State.Handle();
        }
    }
}
