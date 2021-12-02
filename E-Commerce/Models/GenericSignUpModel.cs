namespace E_Commerce.Models
{
    public class GenericSignUpModel
    {
        public IEnumerable<CountryViewModel>? Countries { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
