using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Deliveries : Orders
    {
        private Cities cityId;
        private Couriers courierId;
        private string status;
        private DateTime deliveryDate;

        public Cities CityId { get => cityId; set => cityId = value; }
        public Couriers CourierId { get => courierId; set => courierId = value; }
        public string Status { get => status; set => status = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
    }
}
