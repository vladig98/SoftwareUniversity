﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public interface ICar
    {
        string Model { get; }
        string Driver { get; set; }
        string UseBrakes();
        string PushGasPedal();
    }
}
