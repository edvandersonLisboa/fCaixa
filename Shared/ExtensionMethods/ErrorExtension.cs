using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.ValueObjects;

namespace Shared.ExtensionMethods
{
    public static class ErrorExtension
    {
        public static string GetAsSingleMessage(this IEnumerable<Error> errors)
        {
            if (errors is null || !errors.Any())
                return string.Empty;

            return string.Join(". ", errors.Select(x => x.Message + ". "));
        }
    }
}
