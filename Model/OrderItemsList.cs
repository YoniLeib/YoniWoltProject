using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItemsList : List<OrderItems>
    {
        public OrderItemsList() { }
        public OrderItemsList(IEnumerable<OrderItems> list) : base(list) { }
        public OrderItemsList(IEnumerable<BaseEntity> list) : base(list.Cast<OrderItems>().ToList()) { }
    }
}
