using System.ComponentModel.DataAnnotations.Schema;

namespace GloryECommerce.Domain.Entities
{
  public class File : BaseEntity
  {
    public required string FileName { get; set; }
    public required string Path { get; set; }
    public required string Storage { get; set; }

    [NotMapped]
    public override DateTime? UpdatedAt
    {
      get => base.UpdatedAt;
      set => base.UpdatedAt = value;
    }
  }
}
