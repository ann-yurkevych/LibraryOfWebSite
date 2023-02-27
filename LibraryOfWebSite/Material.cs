using System;
using System.Collections.Generic;

namespace LibraryOfWebSite;

public partial class Material
{
    public int Id { get; set; }

    public string MaterialName { get; set; } = null!;

    public int MaterialQuality { get; set; }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
