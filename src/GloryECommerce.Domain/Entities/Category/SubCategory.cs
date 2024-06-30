using GloryECommerce.Domain.Entities.Shop;

namespace GloryECommerce.Domain.Entities.Category
{
  public class SubCategory : BaseEntity<Ulid>
  {
    public SubCategory()
    {
      ShopCategories = new HashSet<ShopCategory>();
      Products = new HashSet<Product.Product>();
    }

    public required string Name { get; set; }
    public string? Description { get; set; }

    public Ulid CategoryId { get; set; }
    public required Category Category { get; set; }
    public virtual ICollection<ShopCategory> ShopCategories { get; set; }
    public virtual ICollection<Product.Product> Products { get; set; }
  }
}
