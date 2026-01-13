using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ItemsInMenu : BaseEntity
    {
        private Menus menuId;
        private string name;
        private double price;

        public Menus MenuId { get => menuId; set => menuId = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
    }
}
