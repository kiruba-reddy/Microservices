namespace UserLogin.Models
{
    public class Address
    {
        public int UserAddresId { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public User user { get; set; }

    }
}
