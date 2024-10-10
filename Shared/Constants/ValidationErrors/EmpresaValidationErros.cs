namespace Shared.Constants.ValidationErrors
{
    public class EmpresaValidationErros
    {
        public const string EMPRESA_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string EMPRESA_VALIDATION_NOME_REQUIRED = "O nome da empresa � obrigat�rio.";
        public const string EMPRESA_VALIDATION_TIPO_REQUIRED = "O tipo da empresa � obrigat�rio.";
        public const string EMPRESA_VALIDATION_NOME_LENGTH = "O nome da empresa deve ter entre 3 e 100 caracteres.";
        public const string EMPRESA_VALIDATION_TIPO_INVALID = "O tipo da empresa fornecido � inv�lido.";
        public const string EMPRESA_VALIDATION_DUPLICATE = "J� existe uma empresa com o mesmo nome e tipo.";
    }
}
