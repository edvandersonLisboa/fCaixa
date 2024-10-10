using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ValueObjects
{
    public class Error : ValueObject
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public Error(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
