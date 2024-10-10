namespace Shared.Constants.ValidationErrors
{
    public class ClaimValidationErros
    {
        public const string CLAIM_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string CLAIM_VALIDATION_NOME_REQUIRED = "O nome da claim � obrigat�rio.";
        public const string CLAIM_VALIDATION_TIPO_REQUIRED = "O tipo da claim � obrigat�rio.";
        public const string CLAIM_VALIDATION_NOME_LENGTH = "O nome da claim deve ter entre 3 e 100 caracteres.";
        public const string CLAIM_VALIDATION_TIPO_INVALID = "O tipo da claim fornecido � inv�lido.";
        public const string CLAIM_VALIDATION_DUPLICATE = "J� existe uma claim com o mesmo nome e tipo.";
    }
}
