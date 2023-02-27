using System;
using System.Collections.Generic;

namespace LibraryOfWebSite;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ProductManufacturesId { get; set; }

    public virtual ProductManufacture ProductManufactures { get; set; } = null!;
}
