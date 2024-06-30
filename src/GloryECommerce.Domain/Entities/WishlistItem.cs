namespace GloryECommerce.Domain.Entities
{
  public class WishlistItem
  {
    public Ulid UserId { get; set; }
    public Ulid ProductId { get; set; }

    public required virtual User User { get; set; }
    public virtual Product.Product? Product { get; set; }
  }
}
