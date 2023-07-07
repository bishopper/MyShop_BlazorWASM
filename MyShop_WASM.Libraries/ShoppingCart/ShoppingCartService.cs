using MyShop_WASM.Libraries.Product.Models;
using MyShop_WASM.Libraries.ShoppingCart.Models;
using MyShop_WASM.Libraries.Storage;

namespace MyShop_WASM.Libraries.ShoppingCart
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IStorageService _storageService;
        public ShoppingCartService(IStorageService storageService)
        {
            this._storageService = storageService;
        }


        public void AddProduct(ProductModel product, int quantity)
        {
            var items = Get().Items;
            if (HasProduct(product.Sku))
            {
                var item = items.First(i => i.Product.Sku == product.Sku);
                item.UpdateQuantity(product, quantity);
            }
            else
            {
                items.Add(new ShoppingCartItemModel(product, quantity));
            }
        }

        public int Count()
        {
            return Get().Items.Count();
        }

        public void DeleteProduct(ShoppingCartItemModel item)
        {
            var items = Get().Items;
            if (HasProduct(item.Product.Sku))
            {
                items.Remove(items.First(i => i.Product.Sku == item.Product.Sku));
            }
        }

        public ShoppingCartModel Get()
        {
            return _storageService.shoppingCart;
        }

        public bool HasProduct(string sku)
        {
            var shoppingCart = Get();
            return shoppingCart.Items.Any(p => p.Product.Sku == sku);
        }
    }
}
