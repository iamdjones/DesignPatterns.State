using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Example
{
    public class TCPConnection
    {
        private TCPState _state;

        public TCPConnection()
        {
            _state = new TCPClosed();
        }

        public void ActiveOpen()
        {
            _state.ActiveOpen(this);
        }

        public void PassiveOpen()
        {
            _state.PassiveOpen(this);
        }

        public void Close()
        {
            _state.Close(this);
        }

        public void Send()
        {
            _state.Send(this);
        }

        public void Acknowledge()
        {
            _state.Acknowledge(this);
        }

        public void Synchronize()
        {
            _state.Synchronize(this);
        }

        public void ChangeState(TCPState state)
        {
            _state = state;
        }

        public void ProcessOctet(TCPOctetStream stream)
        {
            // do work
        }
    }
}
