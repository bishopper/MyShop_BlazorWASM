namespace MyShop_WASM.Libraries.Product.Models
{
    public class ProductModel
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Slug
        {
            get
            {
                return Sku.ToLower();
            }
        }
        public string FullUrl
        {
            get
            {

                return string.Format("/Product/{0}", Slug);
            }
        }
        public ProductModel(string sku, string name, int price, string image)
        {
            this.Sku = sku;
            this.Name = name;
            this.Price = price;
            this.Image = image;
        }
    }
}
