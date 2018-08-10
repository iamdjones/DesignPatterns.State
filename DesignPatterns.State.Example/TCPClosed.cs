using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Example
{
    public class TCPClosed : TCPState
    {
        public override void ActiveOpen(TCPConnection connection)
        {
            // send SYN, receive SYN, ACK, etc.
            ChangeState(connection, new TCPEstablished());
        }
    }
}
