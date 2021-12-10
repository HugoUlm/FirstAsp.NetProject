namespace E_Commerce.Models
{
    public class ShoppingCartItemViewModel
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public byte[] Images { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ProductNo { get; set; }
    }
}
