using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orders : BaseEntity
    {
        private int estimatedTime;
        private Restaurants restaurantId;
        private Users userId;

        public int EstimatedTime { get => estimatedTime; set => estimatedTime = value; }
        public Restaurants RestaurantId { get => restaurantId; set => restaurantId = value; }
        public Users UserId { get => userId; set => userId = value; }
    }
}
