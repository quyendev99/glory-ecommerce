using System.ComponentModel.DataAnnotations;

namespace GloryECommerce.Application.Enums
{
  public enum ShopStatuses
  {
    [Display(Name = "Open")]
    Open = 1,

    [Display(Name = "Closed")]
    Closed = 2,

    [Display(Name = "Maintenance")]
    Maintenance = 3,

    [Display(Name = "Coming Soon")]
    ComingSoon = 4,
  }
}
