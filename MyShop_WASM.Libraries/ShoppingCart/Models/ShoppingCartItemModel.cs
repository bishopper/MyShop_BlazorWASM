using MyShop_WASM.Libraries.Product.Models;

namespace MyShop_WASM.Libraries.ShoppingCart.Models
{
    public class ShoppingCartItemModel
    {
        public ProductModel Product { get; }
        public int Price { get; protected set; }
        public int Quantity { get; set; }
        public int TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }
        public ShoppingCartItemModel(ProductModel product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public void UpdateQuantity(ProductModel product, int quantity)
        {
            Price = product.Price;
            Quantity = quantity;
        }
    }
}
