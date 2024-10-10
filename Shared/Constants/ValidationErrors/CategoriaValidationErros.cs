namespace Shared.Constants.ValidationErrors
{
    public class CategoriaValidationErros
    {
        public const string CATEGORIA_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string CATEGORIA_VALIDATION_NOME_REQUIRED = "O nome da categoria é obrigatório.";
        public const string CATEGORIA_VALIDATION_TIPO_REQUIRED = "O tipo da categoria é obrigatório.";
        public const string CATEGORIA_VALIDATION_NOME_LENGTH = "O nome da categoria deve ter entre 3 e 100 caracteres.";
        public const string CATEGORIA_VALIDATION_NOME_IS_NOT_NULL = "O nome não pode ser nulo";
        public const string CATEGORIA_VALIDATION_TIPO_INVALID = "O tipo da categoria fornecido é inválido.";
        public const string CATEGORIA_VALIDATION_DUPLICATE = "Já existe uma categoria com o mesmo nome e tipo.";
     

    }
}
