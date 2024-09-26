using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartApp.Models
{
    public class BaseDto
    {
        public string ErrorMessage { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }

    }
    public class ISingleItem
    {
        public object Item { get; set; }
    }
    public class ItemList
    {
        public IList list { get; set; }
    }
}
