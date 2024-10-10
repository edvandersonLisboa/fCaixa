namespace Shared.Constants.ValidationErrors
{
    public class CartValidationErros
    {
        public const string CART_VALIDATION_ID = "N�o foi encontrado o Id para essa valida��o";
        public const string CART_VALIDATION_NOME_REQUIRED = "O nome do carrinho � obrigat�rio.";
        public const string CART_VALIDATION_TIPO_REQUIRED = "O tipo do carrinho � obrigat�rio.";
        public const string CART_VALIDATION_NOME_LENGTH = "O nome do carrinho deve ter entre 3 e 100 caracteres.";
        public const string CART_VALIDATION_TIPO_INVALID = "O tipo do carrinho fornecido � inv�lido.";
        public const string CART_VALIDATION_DUPLICATE = "J� existe um carrinho com o mesmo nome e tipo.";
        public const string CART_VALIDATION_NOME_IS_NOT_NULL = "O nome N�o pode ser nulo";

        public const string CART_VALIDATION_COUNT_ITEM_REQUIRED = "O carrinho deve ter pelo menos um item.";
        public const string CART_VALIDATION_VALOR_TOTAL_MAIOR_QUE_ZERO = "O Valor Total do carrinho tem que ser maior que zero.";
    }
}
