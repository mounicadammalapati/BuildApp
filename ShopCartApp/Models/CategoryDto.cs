using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartApp.Models
{
    public class CategoryDto:BaseDto
    {
        public CategoryDto()
        {
            this.IsSuccess = true;
        }
        public int Id { get; set; }

        public string CategoryName { get; set; } = null!;

        public string UpdatedBy { get; set; } = null!;

        public string UpdatedWhen { get; set; } = null!;

        public string? Description { get; set; }
    }
}
