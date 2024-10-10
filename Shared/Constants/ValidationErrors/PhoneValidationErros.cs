namespace Shared.Constants.ValidationErrors
{
    public class PhoneValidationErros
    {
        public const string PHONE_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string PHONE_VALIDATION_NOME_REQUIRED = "O nome do telefone é obrigatório.";
        public const string PHONE_VALIDATION_TIPO_REQUIRED = "O tipo do telefone é obrigatório.";
        public const string PHONE_VALIDATION_NOME_LENGTH = "O nome do telefone deve ter entre 3 e 100 caracteres.";
        public const string PHONE_VALIDATION_TIPO_INVALID = "O tipo do telefone fornecido é inválido.";
        public const string PHONE_VALIDATION_DUPLICATE = "Já existe um telefone com o mesmo nome e tipo.";
    }
}
