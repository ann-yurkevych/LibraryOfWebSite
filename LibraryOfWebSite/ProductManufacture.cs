using System;
using System.Collections.Generic;

namespace LibraryOfWebSite;

public partial class ProductManufacture
{
    public int Id { get; set; }

    public int YearOfRelease { get; set; }

    public string NameProducer { get; set; } = null!;

    public string QualityRate { get; set; } = null!;

    public DateTime ExpirationDate { get; set; }

    public int ProductsId { get; set; }

    public virtual ICollection<Country> Countries { get; } = new List<Country>();

    public virtual Product Products { get; set; } = null!;
}
