namespace Shared.Constants.ValidationErrors
{
    public class PhoneValidationErros
    {
        public const string PHONE_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string PHONE_VALIDATION_NOME_REQUIRED = "O nome do telefone � obrigat�rio.";
        public const string PHONE_VALIDATION_TIPO_REQUIRED = "O tipo do telefone � obrigat�rio.";
        public const string PHONE_VALIDATION_NOME_LENGTH = "O nome do telefone deve ter entre 3 e 100 caracteres.";
        public const string PHONE_VALIDATION_TIPO_INVALID = "O tipo do telefone fornecido � inv�lido.";
        public const string PHONE_VALIDATION_DUPLICATE = "J� existe um telefone com o mesmo nome e tipo.";
    }
}
