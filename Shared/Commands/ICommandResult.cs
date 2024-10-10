﻿using Shared.ValueObjects;


namespace Shared.Commands
{
    public interface ICommandResult
    {
        bool Success { get; }
        string Message { get; }
        ICollection<Error> Errors { get; }
    }
}
