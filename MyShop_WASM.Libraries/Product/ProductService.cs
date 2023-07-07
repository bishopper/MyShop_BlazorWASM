using MyShop_WASM.Libraries.Product.Models;
using MyShop_WASM.Libraries.Storage;

namespace MyShop_WASM.Libraries.Product
{
    public class ProductService : IProductService
    {
        private readonly IStorageService _storageService;

        public ProductService(IStorageService storageService)
        {
            this._storageService = storageService;
        }
        public IList<ProductModel> GetAll()
        {
            return _storageService.products.ToList();
        }

        public ProductModel? GetProduct(string sku)
        {
            return _storageService.products.FirstOrDefault(x => x.Sku == sku);
        }

        public ProductModel? GetProductBySlug(string slug)
        {
            return _storageService.products.FirstOrDefault(x => x.Slug == slug);
        }
    }
}
