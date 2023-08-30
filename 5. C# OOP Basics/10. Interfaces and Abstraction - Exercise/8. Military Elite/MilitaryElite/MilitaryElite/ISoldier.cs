using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ISoldier
    {
        string id { get; }
        string firstName { get; }
        string lastName { get; }
    }
}
