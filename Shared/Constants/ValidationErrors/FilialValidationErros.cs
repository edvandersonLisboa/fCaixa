namespace Shared.Constants.ValidationErrors
{
    public class FilialValidationErros
    {
        public const string FILIAL_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string FILIAL_VALIDATION_NOME_REQUIRED = "O nome da filial � obrigat�rio.";
        public const string FILIAL_VALIDATION_TIPO_REQUIRED = "O tipo da filial � obrigat�rio.";
        public const string FILIAL_VALIDATION_NOME_LENGTH = "O nome da filial deve ter entre 3 e 100 caracteres.";
        public const string FILIAL_VALIDATION_TIPO_INVALID = "O tipo da filial fornecido � inv�lido.";
        public const string FILIAL_VALIDATION_DUPLICATE = "J� existe uma filial com o mesmo nome e tipo.";
    }
}
