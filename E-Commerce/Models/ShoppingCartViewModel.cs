namespace E_Commerce.Models
{
    public class ShoppingCartViewModel
    {
        public int? Id { get; set; }
        public List<ShoppingCartItemViewModel> Items { get; set; }
    }
}
