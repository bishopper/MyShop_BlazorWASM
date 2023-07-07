using MyShop_WASM.Libraries.Product.Models;

namespace MyShop_WASM.Libraries.Storage
{
    public class StorageService : IStorageService
    {
        public IList<ProductModel> products { get; private set; }

        public ShoppingCartModel shoppingCart { get; private set; }

        public StorageService()
        {
            products = new List<ProductModel>();
            shoppingCart = new ShoppingCartModel();

            AddProduct(new ProductModel("BUBBLES-GUMBALL-APRON", "A Gumball for Your Thoughts Apron", 24, "bubbles-gumball-apron-black.jpg"));
            AddProduct(new ProductModel("REX-MICROCONTROLLERS-APRON", "Great Microcontrollers Think Alike Apron", 24, "rex-microcontrollers-apron-black.jpg"));
            AddProduct(new ProductModel("DOLORES-COMPUTE-BASEBALLHAT", "I Compute, Therefore I Am Baseball Hat", 29, "dolores-compute-baseballhat-black.jpg"));
            AddProduct(new ProductModel("BUBBLES-GUMBALL-BASEBALLHAT", "A Gumball for Your Thoughts Baseball Hat", 29, "bubbles-gumball-baseballhat-black.jpg"));
            AddProduct(new ProductModel("REX-MICROCONTROLLERS-BASEBALLHAT", "Great Microcontrollers Think Alike Baseball Hat", 29, "rex-microcontrollers-baseballhat-black.jpg"));
            AddProduct(new ProductModel("DOLORES-COMPUTE-MUG", "I Compute, Therefore I Am Mug", 16, "dolores-compute-mug-black.jpg"));
            AddProduct(new ProductModel("DOLORES-COMPUTE-TSHIRT", "I Compute, Therefore I Am T-shirt", 26, "dolores-compute-tshirt-black.jpg"));
            AddProduct(new ProductModel("REX-MICROCONTROLLERS-TSHIRT", "Great Microcontrollers Think Alike T-shirt", 26, "rex-microcontrollers-tshirt-black.jpg"));
        }
        private void AddProduct(ProductModel product)
        {
            if (!products.Any(p => p.Sku == product.Sku))
            {
                products.Add(product);
            }
        }
    }
}
