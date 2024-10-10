namespace Shared.Constants.ValidationErrors
{
    public class FuncionarioValidationErros
    {
        public const string FUNCIONARIO_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string FUNCIONARIO_VALIDATION_NOME_REQUIRED = "O nome do funcion�rio � obrigat�rio.";
        public const string FUNCIONARIO_VALIDATION_TIPO_REQUIRED = "O tipo do funcion�rio � obrigat�rio.";
        public const string FUNCIONARIO_VALIDATION_NOME_LENGTH = "O nome do funcion�rio deve ter entre 3 e 100 caracteres.";
        public const string FUNCIONARIO_VALIDATION_TIPO_INVALID = "O tipo do funcion�rio fornecido � inv�lido.";
        public const string FUNCIONARIO_VALIDATION_DUPLICATE = "J� existe um funcion�rio com o mesmo nome e tipo.";
    }
}
