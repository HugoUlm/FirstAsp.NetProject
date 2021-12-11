using Newtonsoft.Json;

namespace E_Commerce.Models
{
    public class ShoppingCartItemViewModel
    {
        [JsonProperty("Id")]
        public int? Id { get; set; }
        [JsonProperty("Size")]
        public int Size { get; set; }
        [JsonProperty("Price")]
        public int Price { get; set; }
        [JsonProperty("Images")]
        public byte[] Images { get; set; }
        [JsonProperty("Brand")]
        public string Brand { get; set; }
        [JsonProperty("Model")]
        public string Model { get; set; }
        [JsonProperty("ProductNo")]
        public string ProductNo { get; set; }
    }
}
