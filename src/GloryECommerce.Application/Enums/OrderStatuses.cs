using System.ComponentModel.DataAnnotations;

namespace GloryECommerce.Application.Enums
{
  public enum OrderStatuses
  {
    [Display(Name = "Pending Payment")]
    PendingPayment = 1,

    [Display(Name = "Awaiting Fulfillment")]
    AwaitingFulfillment = 2,

    [Display(Name = "Partially Shipped")]
    PartiallyShipped = 3,

    [Display(Name = "Shipped")]
    Shipped = 4,

    [Display(Name = "Out for Delivery")]
    OutForDelivery = 5,

    [Display(Name = "Delivered")]
    Delivered = 6,

    [Display(Name = "Return Requested")]
    ReturnRequested = 7,

    [Display(Name = "Return Received")]
    ReturnReceived = 8,

    [Display(Name = "Return Processed")]
    ReturnProcessed = 9,

    [Display(Name = "Cancelled")]
    Cancelled = 10
  }
}
