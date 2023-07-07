using MyShop_WASM.Libraries.Product.Models;
using MyShop_WASM.Libraries.ShoppingCart.Models;

namespace MyShop_WASM.Libraries.ShoppingCart
{
    public interface IShoppingCartService
    {
        ShoppingCartModel Get();
        void AddProduct(ProductModel product, int quantity);
        void DeleteProduct(ShoppingCartItemModel item);
        int Count();
        bool HasProduct(string sku);
    }
}
