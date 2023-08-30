using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ILeutenantGeneral
    {
        List<IPrivate> privates { get; }
    }
}
