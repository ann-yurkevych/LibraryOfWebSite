using System;
using System.Collections.Generic;

namespace LibraryOfWebSite;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string YearProduction { get; set; } = null!;

    public string YearRelease { get; set; } = null!;

    public int CategoryId { get; set; }

    public decimal Price { get; set; }

    public int MaterialId { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Material { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; } = new List<Material>();

    public virtual ICollection<ProductManufacture> ProductManufactures { get; } = new List<ProductManufacture>();
}
