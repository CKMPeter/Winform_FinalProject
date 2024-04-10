using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm
{
    public class Cart
    {
        List<OrderedItem> items = new List<OrderedItem>();

        public List<OrderedItem> Items { get { return items; } set { items = value; } }

        public Cart(List<OrderedItem> items) 
        {
            this.items = items; 
        }
    }
}
