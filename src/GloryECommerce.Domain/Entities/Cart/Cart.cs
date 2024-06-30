namespace GloryECommerce.Domain.Entities.Cart
{
  public class Cart : BaseEntity<Ulid>
  {
    public Cart()
    {
      Items = new HashSet<CartItem>();
    }

    public Ulid UserId { get; set; }
    public required virtual User User { get; set; }

    public virtual ICollection<CartItem> Items { get; set; }
  }
}
