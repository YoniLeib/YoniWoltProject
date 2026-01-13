using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenusList : List<Menus>
    {
        public MenusList() { }
        public MenusList(IEnumerable<Menus> list) : base(list) { }
        public MenusList(IEnumerable<BaseEntity> list) : base(list.Cast<Menus>().ToList()) { }
    }
}
