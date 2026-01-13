using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VehicleTypeList : List<VehicleType>
    {
        public VehicleTypeList() { }
        public VehicleTypeList(IEnumerable<VehicleType> list) : base(list) { }
        public VehicleTypeList(IEnumerable<BaseEntity> list) : base(list.Cast<VehicleType>().ToList()) { }
    }
}
