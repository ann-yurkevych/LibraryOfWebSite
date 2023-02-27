using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryOfWebSite;

public partial class Department
{
    public int Id { get; set; }
    [Display(Name = "Categories")]
    public string DepartmentName { get; set; } = null!;
    [Required(ErrorMessage ="You should put some data")]
    [Display(Name = "Code")]

    public int DepartmentNameId { get; set; }
    [Display(Name = "Amount of discount per year")]

    public int DepartmentSales { get; set; }
    

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
