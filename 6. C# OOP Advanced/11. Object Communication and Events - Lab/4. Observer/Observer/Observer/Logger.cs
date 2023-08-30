using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public abstract class Logger : IHandler
    {
        private IHandler successor;

        public abstract void Handle(LogType type, string message);

        public void SetSuccessor(IHandler successor)
        {
            this.successor = successor;
        }

        protected void PassToSuccessor(LogType type, string message)
        {
            if (successor != null)
            {
                successor.Handle(type, message);
            }
        }
    }
}

