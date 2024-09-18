using System;
using System.Collections.Generic;

namespace ShopCartApp.Entities;

public partial class Image
{
    public int Id { get; set; }

    public byte[]? Imagedata { get; set; }

    public int? ProductId { get; set; }

    public string UpdatedWhen { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public virtual Product? Product { get; set; }
}
