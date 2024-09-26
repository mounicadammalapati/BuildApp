using ShopCartApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartApp.Repository
{
    public interface ICategoryRepo
    {
        public List<CategoryDto> GetCategories();
       
    }
}
