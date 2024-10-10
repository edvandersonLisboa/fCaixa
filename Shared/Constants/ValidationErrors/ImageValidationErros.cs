namespace Shared.Constants.ValidationErrors
{
    public class ImageValidationErros
    {
        public const string IMAGE_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string IMAGE_VALIDATION_NOME_REQUIRED = "O nome da imagem � obrigat�rio.";
        public const string IMAGE_VALIDATION_TIPO_REQUIRED = "O tipo da imagem � obrigat�rio.";
        public const string IMAGE_VALIDATION_NOME_LENGTH = "O nome da imagem deve ter entre 3 e 100 caracteres.";
        public const string IMAGE_VALIDATION_TIPO_INVALID = "O tipo da imagem fornecido � inv�lido.";
        public const string IMAGE_VALIDATION_DUPLICATE = "J� existe uma imagem com o mesmo nome e tipo.";
    }
}
