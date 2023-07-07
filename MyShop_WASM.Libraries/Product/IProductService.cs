using MyShop_WASM.Libraries.Product.Models;

namespace MyShop_WASM.Libraries.Product
{
    public interface IProductService
    {
        ProductModel? GetProduct(string sku);
        ProductModel? GetProductBySlug(string slug);
        IList<ProductModel> GetAll();
    }
}
