namespace Shared.Constants.ValidationErrors
{
    public class CorValidationErros
    {
        public const string COR_VALIDATION_ID = "Id não é valido";

        public const string COR_VALIDATION_NOME_REQUIRED = "O nome da cor é obrigatório.";
        public const string COR_VALIDATION_TIPO_REQUIRED = "O tipo da cor é obrigatório.";
        public const string COR_VALIDATION_NOME_LENGTH = "O nome da cor deve ter entre 3 e 100 caracteres.";
        public const string COR_VALIDATION_TIPO_INVALID = "O tipo da cor fornecido é inválido.";
        public const string COR_VALIDATION_DUPLICATE = "Já existe uma cor com o mesmo nome e tipo.";
        public const string COR_VALIDATION_NOME_IS_NOT_NULL = "O nome nâo pode ser nulo";
    }
}
