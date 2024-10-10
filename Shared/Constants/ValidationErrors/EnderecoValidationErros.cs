namespace Shared.Constants.ValidationErrors
{
    public class EnderecoValidationErros
    {
        public const string ENDERECO_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string ENDERECO_VALIDATION_NOME_REQUIRED = "O nome do endere�o � obrigat�rio.";
        public const string ENDERECO_VALIDATION_TIPO_REQUIRED = "O tipo do endere�o � obrigat�rio.";
        public const string ENDERECO_VALIDATION_NOME_LENGTH = "O nome do endere�o deve ter entre 3 e 100 caracteres.";
        public const string ENDERECO_VALIDATION_TIPO_INVALID = "O tipo do endere�o fornecido � inv�lido.";
        public const string ENDERECO_VALIDATION_DUPLICATE = "J� existe um endere�o com o mesmo nome e tipo.";
    }
}
