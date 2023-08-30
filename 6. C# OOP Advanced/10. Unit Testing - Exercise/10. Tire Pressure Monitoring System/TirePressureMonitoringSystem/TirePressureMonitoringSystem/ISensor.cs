using System;
using System.Collections.Generic;
using System.Text;

namespace TirePressureMonitoringSystem
{
    public interface ISensor
    {
        double PopNextPressurePsiValue();
    }
}
