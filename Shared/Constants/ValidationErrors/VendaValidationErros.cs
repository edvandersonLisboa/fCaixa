namespace Shared.Constants.ValidationErrors
{
    public class VendaValidationErros
    {
        public const string VENDA_VALIDATION_ID = "Não foi encontrado o Id para essa validação";
        public const string VENDA_VALIDATION_NOME_REQUIRED = "O nome da venda é obrigatório.";
        public const string VENDA_VALIDATION_TIPO_REQUIRED = "O tipo da venda é obrigatório.";
        public const string VENDA_VALIDATION_NOME_LENGTH = "O nome da venda deve ter entre 3 e 100 caracteres.";
        public const string VENDA_VALIDATION_TIPO_INVALID = "O tipo da venda fornecido é inválido.";
        public const string VENDA_VALIDATION_DUPLICATE = "Já existe uma venda com o mesmo nome e tipo.";
    }
}
