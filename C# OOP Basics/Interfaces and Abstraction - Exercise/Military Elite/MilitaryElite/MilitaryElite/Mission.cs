using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission : IMission
    {
        public string codeName { get; private set; }
        public StateEnum state { get; private set; }
        public bool parsed { get; private set; }
        public void CompleteMission()
        {
            this.state = StateEnum.Finished;
        }

        public Mission(string codeName, string state)
        {
            this.codeName = codeName;
            StateEnum parsedEnum;
            if (Enum.TryParse(state, out parsedEnum))
            {
                this.state = parsedEnum;
                parsed = true;
            }
            else
            {
                parsed = false;
            }
        }

        public override string ToString()
        {
            return string.Format($"Code Name: {codeName} State: {state.ToString()}");
        }
    }
}
