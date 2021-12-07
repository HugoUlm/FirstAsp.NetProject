namespace E_Commerce.Models
{
    public class GenericSignUpViewModel
    {
        public IEnumerable<CountryViewModel>? Countries { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
