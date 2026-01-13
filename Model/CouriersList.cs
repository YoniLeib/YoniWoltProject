using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CouriersList : List<Couriers>
    {
        public CouriersList() { }
        public CouriersList(IEnumerable<Couriers> list) : base(list) { }
        public CouriersList(IEnumerable<BaseEntity> list) : base(list.Cast<Couriers>().ToList()) { }
    }
}
