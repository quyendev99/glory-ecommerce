namespace GloryECommerce.Domain.Entities.Address
{
  public class City : BaseEntity<Ulid>
  {
    public Guid CountryId { get; set; }
    public required string Name { get; set; }

    public virtual required Country Country { get; set; }
    public virtual required ICollection<Address> Addresses { get; set; }
  }
}
