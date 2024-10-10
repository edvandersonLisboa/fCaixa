namespace Shared.Constants.ValidationErrors
{
    public class MarcaValidationErros
    {
        public const string MARCA_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string MARCA_VALIDATION_NOME_REQUIRED = "O nome da marca � obrigat�rio.";
        public const string MARCA_VALIDATION_TIPO_REQUIRED = "O tipo da marca � obrigat�rio.";
        public const string MARCA_VALIDATION_NOME_LENGTH = "O nome da marca deve ter entre 3 e 100 caracteres.";
        public const string MARCA_VALIDATION_TIPO_INVALID = "O tipo da marca fornecido � inv�lido.";
        public const string MARCA_VALIDATION_DUPLICATE = "J� existe uma marca com o mesmo nome e tipo.";
    }
}
