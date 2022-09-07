﻿using Orders.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T> (T command) where T : Command;
    }
}
