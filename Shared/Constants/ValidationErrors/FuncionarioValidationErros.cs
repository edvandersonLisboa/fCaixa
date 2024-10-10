namespace Shared.Constants.ValidationErrors
{
    public class FuncionarioValidationErros
    {
        public const string FUNCIONARIO_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string FUNCIONARIO_VALIDATION_NOME_REQUIRED = "O nome do funcionário é obrigatório.";
        public const string FUNCIONARIO_VALIDATION_TIPO_REQUIRED = "O tipo do funcionário é obrigatório.";
        public const string FUNCIONARIO_VALIDATION_NOME_LENGTH = "O nome do funcionário deve ter entre 3 e 100 caracteres.";
        public const string FUNCIONARIO_VALIDATION_TIPO_INVALID = "O tipo do funcionário fornecido é inválido.";
        public const string FUNCIONARIO_VALIDATION_DUPLICATE = "Já existe um funcionário com o mesmo nome e tipo.";
    }
}
