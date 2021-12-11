using Newtonsoft.Json;

namespace E_Commerce.Models
{
    public class ShoppingCartViewModel
    {
        [JsonProperty("CartItem")]
        public List<ShoppingCartItemViewModel>? Items { get; set; }
    }
}
