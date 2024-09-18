using System;
using System.Collections.Generic;

namespace ShopCartApp.Entities;

public partial class WishCart
{
    public int Id { get; set; }

    public double? SessoinId { get; set; }

    public int ProductId { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public string UpdatedWhen { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
