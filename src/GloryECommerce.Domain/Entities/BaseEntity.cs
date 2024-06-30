using GloryECommerce.Application.Abstracts;
namespace GloryECommerce.Domain.Entities
{
  public abstract class BaseEntity : BaseEntity<Ulid> { }

  public abstract class BaseEntity<T> : IEntity
  {
    public virtual required T Id { get; set; }

    public bool Deleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public virtual DateTime? UpdatedAt { get; set; }
  }
}
