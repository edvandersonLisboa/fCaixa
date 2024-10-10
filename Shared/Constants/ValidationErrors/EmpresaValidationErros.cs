namespace Shared.Constants.ValidationErrors
{
    public class EmpresaValidationErros
    {
        public const string EMPRESA_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string EMPRESA_VALIDATION_NOME_REQUIRED = "O nome da empresa é obrigatório.";
        public const string EMPRESA_VALIDATION_TIPO_REQUIRED = "O tipo da empresa é obrigatório.";
        public const string EMPRESA_VALIDATION_NOME_LENGTH = "O nome da empresa deve ter entre 3 e 100 caracteres.";
        public const string EMPRESA_VALIDATION_TIPO_INVALID = "O tipo da empresa fornecido é inválido.";
        public const string EMPRESA_VALIDATION_DUPLICATE = "Já existe uma empresa com o mesmo nome e tipo.";
    }
}
