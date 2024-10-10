namespace Shared.Constants.ValidationErrors
{
    public class FornecedorValidationErros
    {
        public const string FORNECEDOR_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string FORNECEDOR_VALIDATION_NOME_REQUIRED = "O nome do fornecedor � obrigat�rio.";
        public const string FORNECEDOR_VALIDATION_TIPO_REQUIRED = "O tipo do fornecedor � obrigat�rio.";
        public const string FORNECEDOR_VALIDATION_NOME_LENGTH = "O nome do fornecedor deve ter entre 3 e 100 caracteres.";
        public const string FORNECEDOR_VALIDATION_TIPO_INVALID = "O tipo do fornecedor fornecido � inv�lido.";
        public const string FORNECEDOR_VALIDATION_DUPLICATE = "J� existe um fornecedor com o mesmo nome e tipo.";
    }
}
