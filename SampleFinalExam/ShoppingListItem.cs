using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFinalExam
{ // namespace Folder_name
    internal class ShoppingListItem
    {
        public ShoppingListItem()
        {

        }

        public ShoppingListItem(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Quantity}x {Name}";
        }
    }
}
