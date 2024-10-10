namespace Shared.Constants.ValidationErrors
{
    public class ProdutoValidationErros
    {
        public const string PRODUTO_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string PRODUTO_VALIDATION_NOME_REQUIRED = "O nome do produto � obrigat�rio.";
        public const string PRODUTO_VALIDATION_TIPO_REQUIRED = "O tipo do produto � obrigat�rio.";
        public const string PRODUTO_VALIDATION_NOME_LENGTH = "O nome do produto deve ter entre 3 e 100 caracteres.";
        public const string PRODUTO_VALIDATION_TIPO_INVALID = "O tipo do produto fornecido � inv�lido.";
        public const string PRODUTO_VALIDATION_DUPLICATE = "J� existe um produto com o mesmo nome e tipo.";
    }
}
