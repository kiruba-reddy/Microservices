namespace UserLogin.models;

public class User
{
    public int AddressId { get; set; }
    public int UserId { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public User user { get; set; }
}
