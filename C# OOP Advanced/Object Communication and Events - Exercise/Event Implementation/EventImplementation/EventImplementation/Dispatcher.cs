using System;
using System.Collections.Generic;
using System.Text;

namespace EventImplementation
{
    public delegate void NameChangeEventHandler(Dispatcher d, NameChangeEventArgs e);

    public class Dispatcher
    {
        private string name;
        private Handler handler;

        public Dispatcher(Handler handler)
        {
            this.handler = handler;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public event NameChangeEventHandler NameChange;

        public void OnNameChange(NameChangeEventArgs args)
        {
            handler.OnDispatcherNameChange(this, args);
        }
    }
}
