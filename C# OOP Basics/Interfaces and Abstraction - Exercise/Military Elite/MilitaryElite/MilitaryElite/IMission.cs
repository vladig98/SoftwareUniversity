using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IMission
    {
        string codeName { get; }
        StateEnum state { get; }
        bool parsed { get; }

        void CompleteMission();
    }
}
