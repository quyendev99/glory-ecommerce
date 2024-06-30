namespace GloryECommerce.Domain.Entities
{
  public class User : BaseEntity<Ulid>
  {
    public User()
    {
      Shops = new HashSet<Shop.Shop>();
      Addresses = new HashSet<Address.Address>();
      Wishlists = new HashSet<WishlistItem>();
      Orders = new HashSet<Order.Order>();
    }

    public required string Username { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required byte[] PasswordHashed { get; set; }
    public string? Avatar { get; set; }
    public string? ThumbnailUrl { get; set; }
    public virtual Cart.Cart? Cart { get; set; }

    public virtual ICollection<Shop.Shop> Shops { get; set; }
    public virtual ICollection<Address.Address> Addresses { get; set; }
    public virtual ICollection<WishlistItem> Wishlists { get; set; }
    public virtual ICollection<Order.Order> Orders { get; set; }
  }
}
