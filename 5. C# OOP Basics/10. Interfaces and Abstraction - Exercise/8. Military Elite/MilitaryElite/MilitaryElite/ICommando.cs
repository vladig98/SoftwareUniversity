using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ICommando
    {
        List<IMission> missions { get; }
    }
}
