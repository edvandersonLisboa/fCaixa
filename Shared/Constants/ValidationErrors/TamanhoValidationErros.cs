namespace Shared.Constants.ValidationErrors
{
    public class TamanhoValidationErros
    {
        public const string TAMANHO_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string TAMANHO_VALIDATION_NOME_REQUIRED = "O nome do tamanho é obrigatório.";
        public const string TAMANHO_VALIDATION_TIPO_REQUIRED = "O tipo do tamanho é obrigatório.";
        public const string TAMANHO_VALIDATION_NOME_LENGTH = "O nome do tamanho deve ter entre 3 e 100 caracteres.";
        public const string TAMANHO_VALIDATION_TIPO_INVALID = "O tipo do tamanho fornecido é inválido.";
        public const string TAMANHO_VALIDATION_DUPLICATE = "Já existe um tamanho com o mesmo nome e tipo.";
    }
}
