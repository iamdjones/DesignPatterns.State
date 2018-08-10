using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Structure
{
    public class ConcreteStateB : State
    {
        public override void Handle()
        {
            Console.WriteLine($"{nameof(Handle)} from {nameof(ConcreteStateB)}");
        }
    }
}
