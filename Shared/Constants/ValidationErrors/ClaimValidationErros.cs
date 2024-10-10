namespace Shared.Constants.ValidationErrors
{
    public class ClaimValidationErros
    {
        public const string CLAIM_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string CLAIM_VALIDATION_NOME_REQUIRED = "O nome da claim é obrigatório.";
        public const string CLAIM_VALIDATION_TIPO_REQUIRED = "O tipo da claim é obrigatório.";
        public const string CLAIM_VALIDATION_NOME_LENGTH = "O nome da claim deve ter entre 3 e 100 caracteres.";
        public const string CLAIM_VALIDATION_TIPO_INVALID = "O tipo da claim fornecido é inválido.";
        public const string CLAIM_VALIDATION_DUPLICATE = "Já existe uma claim com o mesmo nome e tipo.";
    }
}
