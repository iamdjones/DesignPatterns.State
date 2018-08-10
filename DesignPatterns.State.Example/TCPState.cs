using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignPatterns.State.Example
{
    public abstract class TCPState
    {
        public virtual void Transmit(TCPConnection connection, TCPOctetStream stream)
        {
            ThrowInvalidOperationException();
        }

        public virtual void ActiveOpen(TCPConnection connection)
        {
            ThrowInvalidOperationException();
        }

        public virtual void PassiveOpen(TCPConnection connection)
        {
            ThrowInvalidOperationException();
        }

        public virtual void Close(TCPConnection connection)
        {
            ThrowInvalidOperationException();
        }

        public virtual void Synchronize(TCPConnection connection)
        {
            ThrowInvalidOperationException();
        }

        public virtual void Acknowledge(TCPConnection connection)
        {
            ThrowInvalidOperationException();
        }

        public virtual void Send(TCPConnection connection)
        {
            ThrowInvalidOperationException();
        }

        protected void ChangeState(TCPConnection connection, TCPState state)
        {
            connection.ChangeState(state);
        }

        private void ThrowInvalidOperationException([CallerMemberName] string callerMemberName = "")
        {
            throw new InvalidOperationException($"Cannot call {callerMemberName} from {GetType().Name}");
        }
    }
}
