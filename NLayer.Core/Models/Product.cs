using Newtonsoft.Json;

namespace NLayer.Core
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }

    }
}
