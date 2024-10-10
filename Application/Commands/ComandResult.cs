using Shared.Commands;
using Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comands
{
    public class CommandResult : ICommandResult
    {
        #region Constructors
        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
            Errors = new List<Error>();
        }

        public CommandResult(bool success, string message, ICollection<Error> errors)
        {
            Success = success;
            Message = message;
            Errors = errors;
        }
        #endregion Constructors

        #region Properties
        public bool Success { get; set; }
        public string Message { get; set; }
        public ICollection<Error> Errors { get; set; }
        #endregion Properties
    }
}
