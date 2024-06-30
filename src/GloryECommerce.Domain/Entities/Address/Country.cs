namespace GloryECommerce.Domain.Entities.Address
{
  public class Country : BaseEntity<Ulid>
  {
    public Country()
    {
      Cities = new HashSet<City>();
      Addresses = new HashSet<Address>();
    }

    public required string Name { get; set; }
    public virtual ICollection<City> Cities { get; set; }
    public virtual required ICollection<Address> Addresses { get; set; }
  }
}
