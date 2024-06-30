using GloryECommerce.Application.Enums;

namespace GloryECommerce.Domain.Entities.Shop
{
  public class Shop : BaseEntity<Ulid>
  {
    public Shop()
    {
      Members = new HashSet<User>();
      Categories = new HashSet<ShopCategory>();
      Products = new HashSet<Product.Product>();
      Reviews = new HashSet<ShopReview>();
    }

    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? ShopAvatar { get; set; }
    public string? ShopThumbnail { get; set; }
    public required bool IsApproved { get; set; }
    public virtual required ShopStatuses Status { get; set; }
    public virtual ICollection<User> Members { get; set; }
    public virtual ICollection<ShopCategory> Categories { get; set; }
    public virtual ICollection<Product.Product> Products { get; set; }
    public virtual ICollection<ShopReview> Reviews { get; set; }
  }
}
