using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RestaurantsList : List<Restaurants>
    {
        public RestaurantsList() { }
        public RestaurantsList(IEnumerable<Restaurants> list) : base(list) { }
        public RestaurantsList(IEnumerable<BaseEntity> list) : base(list.Cast<Restaurants>().ToList()) { }
    }
}
