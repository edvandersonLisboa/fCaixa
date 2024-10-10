namespace Shared.Constants.ValidationErrors
{
    public class FilialValidationErros
    {
        public const string FILIAL_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string FILIAL_VALIDATION_NOME_REQUIRED = "O nome da filial é obrigatório.";
        public const string FILIAL_VALIDATION_TIPO_REQUIRED = "O tipo da filial é obrigatório.";
        public const string FILIAL_VALIDATION_NOME_LENGTH = "O nome da filial deve ter entre 3 e 100 caracteres.";
        public const string FILIAL_VALIDATION_TIPO_INVALID = "O tipo da filial fornecido é inválido.";
        public const string FILIAL_VALIDATION_DUPLICATE = "Já existe uma filial com o mesmo nome e tipo.";
    }
}
