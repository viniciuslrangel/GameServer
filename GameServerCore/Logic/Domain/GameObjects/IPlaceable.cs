﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServerCore.Logic.Domain.GameObjects
{
    public interface IPlaceable : IObjAiBase
    {
        string Name { get; }
        IObjAiBase Owner { get; }
    }
}