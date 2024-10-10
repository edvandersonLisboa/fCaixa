namespace Shared.Constants.ValidationErrors
{
    public class FornecedorValidationErros
    {
        public const string FORNECEDOR_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string FORNECEDOR_VALIDATION_NOME_REQUIRED = "O nome do fornecedor é obrigatório.";
        public const string FORNECEDOR_VALIDATION_TIPO_REQUIRED = "O tipo do fornecedor é obrigatório.";
        public const string FORNECEDOR_VALIDATION_NOME_LENGTH = "O nome do fornecedor deve ter entre 3 e 100 caracteres.";
        public const string FORNECEDOR_VALIDATION_TIPO_INVALID = "O tipo do fornecedor fornecido é inválido.";
        public const string FORNECEDOR_VALIDATION_DUPLICATE = "Já existe um fornecedor com o mesmo nome e tipo.";
    }
}
