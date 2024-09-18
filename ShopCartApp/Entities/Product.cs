using System;
using System.Collections.Generic;

namespace ShopCartApp.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Quantity { get; set; }

    public double Price { get; set; }

    public int? CategoryId { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public string UpdatedWhen { get; set; } = null!;

    public virtual Category? Category { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<WishCart> WishCarts { get; set; } = new List<WishCart>();
}
