namespace GloryECommerce.Domain.Entities.Product
{
  public class Product : BaseEntity<Ulid>
  {
    public Product()
    {
      MediaFiles = new HashSet<File>();
    }

    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? ShortDescription { get; set; }
    public decimal Price { get; set; }
    public int? UnitsInStock { get; set; }
    public required bool IsApproved { get; set; }

    public Ulid? CategoryId { get; set; }
    public Ulid? SubCategoryId { get; set; }
    public Ulid? ShopCategoryId { get; set; }
    public virtual Category.Category? Category { get; set; }
    public virtual Category.SubCategory? SubCategory { get; set; }
    public virtual Shop.ShopCategory? ShopCategory { get; set; }
    public virtual ICollection<File> MediaFiles { get; set; }
  }
}
