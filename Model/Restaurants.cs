using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Restaurants : BaseEntity
    {
        private City cityID;
        private string name;
        private DateTime openTime;
        private DateTime closeTime;

        public City CityId { get => cityID; set => cityID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime OpenTime { get => openTime; set => openTime = value; }
        public DateTime CloseTime { get => closeTime; set => closeTime = value; }
    }
}
