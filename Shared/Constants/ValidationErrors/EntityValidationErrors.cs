using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Constants.ValidationErrors
{
    public class EntityValidationErrors
    {
        public const string LAST_UPDATE_DATETIME_BEFORE_CREATION_TIME_ERROR = "A data de atualização deve ser futura à data de criação do registro";
        public const string UNEXPECTED_EXCEPTION = "Uma exceção inesperada aconteceu";// TODO: Move message to a more generic class
    }
}
