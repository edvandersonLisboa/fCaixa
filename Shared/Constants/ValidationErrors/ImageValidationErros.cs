namespace Shared.Constants.ValidationErrors
{
    public class ImageValidationErros
    {
        public const string IMAGE_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string IMAGE_VALIDATION_NOME_REQUIRED = "O nome da imagem é obrigatório.";
        public const string IMAGE_VALIDATION_TIPO_REQUIRED = "O tipo da imagem é obrigatório.";
        public const string IMAGE_VALIDATION_NOME_LENGTH = "O nome da imagem deve ter entre 3 e 100 caracteres.";
        public const string IMAGE_VALIDATION_TIPO_INVALID = "O tipo da imagem fornecido é inválido.";
        public const string IMAGE_VALIDATION_DUPLICATE = "Já existe uma imagem com o mesmo nome e tipo.";
    }
}
