namespace GloryECommerce.Domain.Entities.Cart
{
  public class CartItem : BaseEntity<Ulid>
  {
    public Ulid CartId { get; set; }
    public Ulid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public virtual required Cart Cart { get; set; }
    public virtual required Product.Product Product { get; set; }
  }
}
