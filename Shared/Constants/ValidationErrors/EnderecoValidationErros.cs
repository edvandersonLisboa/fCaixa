namespace Shared.Constants.ValidationErrors
{
    public class EnderecoValidationErros
    {
        public const string ENDERECO_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string ENDERECO_VALIDATION_NOME_REQUIRED = "O nome do endereço é obrigatório.";
        public const string ENDERECO_VALIDATION_TIPO_REQUIRED = "O tipo do endereço é obrigatório.";
        public const string ENDERECO_VALIDATION_NOME_LENGTH = "O nome do endereço deve ter entre 3 e 100 caracteres.";
        public const string ENDERECO_VALIDATION_TIPO_INVALID = "O tipo do endereço fornecido é inválido.";
        public const string ENDERECO_VALIDATION_DUPLICATE = "Já existe um endereço com o mesmo nome e tipo.";
    }
}
