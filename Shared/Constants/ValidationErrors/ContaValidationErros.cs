namespace Shared.Constants.ValidationErrors
{
    public class ContaValidationErros
    {
        public const string CONTA_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string CONTA_VALIDATION_NOME_REQUIRED = "O nome da conta � obrigat�rio.";
        public const string CONTA_VALIDATION_TIPO_REQUIRED = "O tipo da conta � obrigat�rio.";
        public const string CONTA_VALIDATION_NOME_LENGTH = "O nome da conta deve ter entre 3 e 100 caracteres.";
        public const string CONTA_VALIDATION_TIPO_INVALID = "O tipo da conta fornecido � inv�lido.";
        public const string CONTA_VALIDATION_DUPLICATE = "J� existe uma conta com o mesmo nome e tipo.";
    }
}
