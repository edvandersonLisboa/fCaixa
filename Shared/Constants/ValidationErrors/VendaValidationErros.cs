namespace Shared.Constants.ValidationErrors
{
    public class VendaValidationErros
    {
        public const string VENDA_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string VENDA_VALIDATION_NOME_REQUIRED = "O nome da venda � obrigat�rio.";
        public const string VENDA_VALIDATION_TIPO_REQUIRED = "O tipo da venda � obrigat�rio.";
        public const string VENDA_VALIDATION_NOME_LENGTH = "O nome da venda deve ter entre 3 e 100 caracteres.";
        public const string VENDA_VALIDATION_TIPO_INVALID = "O tipo da venda fornecido � inv�lido.";
        public const string VENDA_VALIDATION_DUPLICATE = "J� existe uma venda com o mesmo nome e tipo.";
    }
}
