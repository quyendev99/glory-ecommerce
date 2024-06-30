using GloryECommerce.Application.Enums;

namespace GloryECommerce.Domain.Entities.Address
{
  public class Address : BaseEntity<Ulid>
  {
    public Ulid UserId { get; set; }
    public Guid CountryId { get; set; }
    public Guid CityId { get; set; }
    public required string PhoneNumber { get; set; }
    public required string AddressLine { get; set; }
    public required string ZipCode { get; set; }

    public required AddressType Type { get; set; }
    public virtual required User User { get; set; }
    public virtual required Country Country { get; set; }
    public virtual required City City { get; set; }
  }
}
