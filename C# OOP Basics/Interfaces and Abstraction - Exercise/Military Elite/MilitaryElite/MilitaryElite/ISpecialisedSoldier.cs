using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ISpecialisedSoldier
    {
        CorpsEnum corps { get; }
        bool parsed { get; }
    }
}
