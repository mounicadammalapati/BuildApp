using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartApp.Models
{
    public class ImageDto:BaseDto
    {
        public int Id { get; set; }

        public byte[]? Imagedata { get; set; }

        public int? ProductId { get; set; }

        public string UpdatedWhen { get; set; } = null!;

        public string UpdatedBy { get; set; } = null!;

    }
}
