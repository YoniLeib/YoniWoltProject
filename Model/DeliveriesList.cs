using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliveriesList : List<Deliveries>
    {
        public DeliveriesList() { }
        public DeliveriesList(IEnumerable<Deliveries> list) : base(list) { }
        public DeliveriesList(IEnumerable<BaseEntity> list) : base(list.Cast<Deliveries>().ToList()) { }
    }
}
