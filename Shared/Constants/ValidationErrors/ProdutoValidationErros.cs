namespace Shared.Constants.ValidationErrors
{
    public class ProdutoValidationErros
    {
        public const string PRODUTO_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string PRODUTO_VALIDATION_NOME_REQUIRED = "O nome do produto é obrigatório.";
        public const string PRODUTO_VALIDATION_TIPO_REQUIRED = "O tipo do produto é obrigatório.";
        public const string PRODUTO_VALIDATION_NOME_LENGTH = "O nome do produto deve ter entre 3 e 100 caracteres.";
        public const string PRODUTO_VALIDATION_TIPO_INVALID = "O tipo do produto fornecido é inválido.";
        public const string PRODUTO_VALIDATION_DUPLICATE = "Já existe um produto com o mesmo nome e tipo.";
    }
}
