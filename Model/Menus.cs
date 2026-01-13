    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Menus : BaseEntity
    {
        private string title;
        private Restaurants restaurantId;

        public string Title { get => title; set => title = value; }
        public Restaurants RestaurantId { get => restaurantId; set => restaurantId = value; }
    }
}
