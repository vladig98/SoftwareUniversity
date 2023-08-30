using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : ICitizen
    {
        public string model { get; private set; }
        public string id { get; private set; }

        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }
    }
}
