namespace GloryECommerce.Domain.Entities.Shop
{
  public class ShopReview : BaseEntity<Ulid>
  {
    public ShopReview()
    {
      MediaFiles = new HashSet<File>();
    }

    public Ulid UserId { get; set; }
    public Ulid ShopId { get; set; }
    public string? Comment { get; set; }
    public required decimal Rating { get; set; }

    public virtual ICollection<File> MediaFiles { get; set; }
  }
}
