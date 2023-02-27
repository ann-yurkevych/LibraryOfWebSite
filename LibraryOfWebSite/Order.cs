using System;
using System.Collections.Generic;

namespace LibraryOfWebSite;

public partial class Order
{
    public int Id { get; set; }

    public int ShippingId { get; set; }

    public virtual Shipping Shipping { get; set; } = null!;
}
