namespace Shared.Constants.ValidationErrors
{
    public class UsuarioValidationErros
    {
        public const string USUARIO_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string USUARIO_VALIDATION_NOME_REQUIRED = "O nome do usuário é obrigatório.";
        public const string USUARIO_VALIDATION_TIPO_REQUIRED = "O tipo do usuário é obrigatório.";
        public const string USUARIO_VALIDATION_NOME_LENGTH = "O nome do usuário deve ter entre 3 e 100 caracteres.";
        public const string USUARIO_VALIDATION_TIPO_INVALID = "O tipo do usuário fornecido é inválido.";
        public const string USUARIO_VALIDATION_DUPLICATE = "Já existe um usuário com o mesmo nome e tipo.";
    }
}
