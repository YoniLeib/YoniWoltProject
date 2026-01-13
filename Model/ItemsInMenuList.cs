using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ItemsInMenuList : List<ItemsInMenu>
    {
        public ItemsInMenuList() { }
        public ItemsInMenuList(IEnumerable<ItemsInMenu> list) : base(list) { }
        public ItemsInMenuList(IEnumerable<BaseEntity> list) : base(list.Cast<ItemsInMenu>().ToList()) { }
    }
}
