using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Structure
{
    public class ConcreteStateA : State
    {
        public override void Handle()
        {
            Console.WriteLine($"{nameof(Handle)} from {nameof(ConcreteStateA)}");
        }
    }
}
