using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItems : BaseEntity
    {
        private ItemsInMenu itemID;
        private Orders orderID;
        private int quantity;

        public ItemsInMenu ItemID { get => itemID; set => itemID = value; }
        public Orders OrderID { get => orderID; set => orderID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
