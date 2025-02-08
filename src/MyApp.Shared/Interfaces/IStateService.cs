﻿using MyApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Shared.Interfaces
{
    public interface IStateService
    {
        List<StateDto> GetStates();
    }
}
