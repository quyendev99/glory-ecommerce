using GloryECommerce.Domain.Entities.Shop;

namespace GloryECommerce.Domain.Entities.Category
{
  public class Category : BaseEntity<Ulid>
  {
    public Category()
    {
      SubCategories = new HashSet<SubCategory>();
      ShopCategories = new HashSet<ShopCategory>();
      Products = new HashSet<Product.Product>();
    }

    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? CategoryImage { get; set; }
    public string? CategoryThumnail { get; set; }

    public virtual ICollection<SubCategory> SubCategories { get; set; }
    public virtual ICollection<ShopCategory> ShopCategories { get; set; }
    public virtual ICollection<Product.Product> Products { get; set; }
  }
}
