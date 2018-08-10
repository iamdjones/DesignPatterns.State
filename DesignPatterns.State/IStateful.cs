using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public interface IStateContext<TStateBehavior> where TStateBehavior : IStateBehavior<IStateContext<TState,TStateBehavior>,TState>
    {
        TStateBehavior Stateful { get; }

        void ChangeStateBehavior()
    }
    public interface IStateBehavior<IStateContext,IState>
    {        
    }


    public class DerpState : IState { }
    public class DerpStateful : IStateBehavior<DerpContext, DerpState>
    {
        public void StatefulMethod(DerpContext context)
        {
            context.ChangeStateful()
        }
    }

    public class DerpContext : IStateContext<DerpState>
    {
        public DerpState State { get; }

        public DerpStateful Stateful { get; }

        public void NotStatefulMethod()
        {

        }

        public void StatefulMethod()
        {
            Stateful.StatefulMethod(this);
        }
    }

}
