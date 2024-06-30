namespace GloryECommerce.Domain.Entities.Shop
{
  public class ShopCategory : BaseEntity<Ulid>
  {
    public ShopCategory()
    {
      Products = new HashSet<Product.Product>();
    }

    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? CategoryImage { get; set; }
    public string? CategoryThumnail { get; set; }

    public required Ulid ShopId { get; set; }
    public Ulid CategoryId { get; set; }
    public Ulid SubCategoryId { get; set; }

    public virtual required Shop Shop { get; set; }
    public virtual Category.Category? Category { get; set; }
    public virtual Category.SubCategory? SubCategory { get; set; }

    public virtual ICollection<Product.Product> Products { get; set; }
  }
}
