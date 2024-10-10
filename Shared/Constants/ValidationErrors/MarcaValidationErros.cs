namespace Shared.Constants.ValidationErrors
{
    public class MarcaValidationErros
    {
        public const string MARCA_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string MARCA_VALIDATION_NOME_REQUIRED = "O nome da marca é obrigatório.";
        public const string MARCA_VALIDATION_TIPO_REQUIRED = "O tipo da marca é obrigatório.";
        public const string MARCA_VALIDATION_NOME_LENGTH = "O nome da marca deve ter entre 3 e 100 caracteres.";
        public const string MARCA_VALIDATION_TIPO_INVALID = "O tipo da marca fornecido é inválido.";
        public const string MARCA_VALIDATION_DUPLICATE = "Já existe uma marca com o mesmo nome e tipo.";
    }
}
