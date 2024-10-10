namespace Shared.Constants.ValidationErrors
{
    public class CategoriaValidationErros
    {
        public const string CATEGORIA_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string CATEGORIA_VALIDATION_NOME_REQUIRED = "O nome da categoria � obrigat�rio.";
        public const string CATEGORIA_VALIDATION_TIPO_REQUIRED = "O tipo da categoria � obrigat�rio.";
        public const string CATEGORIA_VALIDATION_NOME_LENGTH = "O nome da categoria deve ter entre 3 e 100 caracteres.";
        public const string CATEGORIA_VALIDATION_NOME_IS_NOT_NULL = "O nome n�o pode ser nulo";
        public const string CATEGORIA_VALIDATION_TIPO_INVALID = "O tipo da categoria fornecido � inv�lido.";
        public const string CATEGORIA_VALIDATION_DUPLICATE = "J� existe uma categoria com o mesmo nome e tipo.";
     

    }
}
