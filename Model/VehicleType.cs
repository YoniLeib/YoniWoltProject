using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VehicleType : BaseEntity
    {
        private string name;
        private int maxCapacity;
        private int speed;

        public string Name { get => name; set => name = value; }
        public int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }
        public int Speed { get => speed; set => speed = value; }
    }
}
