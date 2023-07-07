using MyShop_WASM.Libraries.Product.Models;

namespace MyShop_WASM.Libraries.Storage
{
    public interface IStorageService
    {
        IList<ProductModel> products { get; }
        ShoppingCartModel shoppingCart { get; }
    }
}
