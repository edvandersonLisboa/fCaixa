namespace Shared.Constants.ValidationErrors
{
    public class ContaValidationErros
    {
        public const string CONTA_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string CONTA_VALIDATION_NOME_REQUIRED = "O nome da conta é obrigatório.";
        public const string CONTA_VALIDATION_TIPO_REQUIRED = "O tipo da conta é obrigatório.";
        public const string CONTA_VALIDATION_NOME_LENGTH = "O nome da conta deve ter entre 3 e 100 caracteres.";
        public const string CONTA_VALIDATION_TIPO_INVALID = "O tipo da conta fornecido é inválido.";
        public const string CONTA_VALIDATION_DUPLICATE = "Já existe uma conta com o mesmo nome e tipo.";
    }
}
