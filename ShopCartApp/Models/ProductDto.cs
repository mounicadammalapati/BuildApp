using ShopCartApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartApp.Models
{
    public class ProductDto:BaseDto
    {
        public ProductDto()
        {
            this.IsSuccess = true;
        }
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Quantity { get; set; }

        public double Price { get; set; }

        public int? CategoryId { get; set; }

        public string UpdatedBy { get; set; } = null!;

        public string UpdatedWhen { get; set; } = null!;

        public Category Category { get; set; } = new Category();

        public List<Image> Images { get; set; } = new List<Image>();

       // public List<WishCart> WishCarts { get; set; } = new List<WishCart>();
    }
}
