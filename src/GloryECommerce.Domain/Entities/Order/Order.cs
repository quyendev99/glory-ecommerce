namespace GloryECommerce.Domain.Entities.Order
{
  public class Order : BaseEntity<Ulid>
  {
    public Order()
    {
      OrderItems = new HashSet<OrderItem>();
    }

    public required Ulid UserId { get; set; }

    public virtual User Customer { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; }
  }
}
