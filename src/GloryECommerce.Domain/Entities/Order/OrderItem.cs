namespace GloryECommerce.Domain.Entities.Order
{
  public class OrderItem : BaseEntity<Ulid>
  {
    public Ulid OrderId { get; set; }
    public Ulid CartItemId { get; set; }

    public virtual Order Order { get; set; }
    public virtual Cart.CartItem Item { get; set; }
  }
}
