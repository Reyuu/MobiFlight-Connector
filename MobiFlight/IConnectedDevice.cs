﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobiFlight
{
    public interface IConnectedDevice
    {
        String Name { get; }
        DeviceType TypeDeprecated { get; }

        void Stop();
    }
}
