﻿using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Handlers
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task<ICommandResult> HandleAsync(T command);
    }
}
