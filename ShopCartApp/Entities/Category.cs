using System;
using System.Collections.Generic;

namespace ShopCartApp.Entities;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public string UpdatedWhen { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
