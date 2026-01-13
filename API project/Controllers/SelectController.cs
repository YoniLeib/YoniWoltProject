using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace API_project.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : ControllerBase
    {
//----------------------------------------------------------------------------------------------------

        [HttpGet]
        [ActionName("CitiesSelector")]
        public CitiesList SelectAllCities()
        {
            CitiesDB db = new CitiesDB();
            CitiesList cities = db.SelectAll();
            return cities;
        }

        [HttpGet]
        [ActionName("CouriersSelector")]
        public CouriersList SelectAllCouriers()
        {
            CouriersDB db = new CouriersDB();
            CouriersList couriers = db.SelectAll();
            return couriers;
        }

        [HttpGet]
        [ActionName("DeliveriesSelector")]
        public DeliveriesList SelectAllDeliveries()
        {
            DeliveriesDB db = new DeliveriesDB();
            DeliveriesList deliveries = db.SelectAll();
            return deliveries;
        }

        [HttpGet]
        [ActionName("ItemsInMenuSelector")]
        public ItemsInMenuList SelectAllItemsInMenu()
        {
            ItemsInMenuDB db = new ItemsInMenuDB();
            ItemsInMenuList itemsInMenu = db.SelectAll();
            return itemsInMenu;
        }

        [HttpGet]
        [ActionName("MenusSelector")]
        public MenusList SelectAllMenus()
        {
            MenusDB db = new MenusDB();
            MenusList menus = db.SelectAll();
            return menus;
        }

        [HttpGet]
        [ActionName("OrderItemsSelector")]
        public OrderItemsList SelectAllOrderItems()
        {
            OrderItemsDB db = new OrderItemsDB();
            OrderItemsList orderitem = db.SelectAll();
            return orderitem;
        }

        [HttpGet]
        [ActionName("OrdersSelector")]
        public OrdersList SelectAllOrders()
        {
            OrdersDB db = new OrdersDB();
            OrdersList order = db.SelectAll();
            return order;
        }

        [HttpGet]
        [ActionName("RestaurantsSelector")]
        public RestaurantsList SelectAllRestaurants()
        {
            RestaurantsDB db = new RestaurantsDB();
            RestaurantsList restaurants = db.SelectAll();
            return restaurants;
        }

        [HttpGet]
        [ActionName("UsersSelector")]
        public UsersList SelectAllUsers()
        {
            UsersDB db = new UsersDB();
            UsersList user = db.SelectAll();
            return user;
        }

        [HttpGet]
        [ActionName("VehicleTypeSelector")]
        public VehicleTypeList SelectAllVehicleType()
        {
            VehicleTypeDB db = new VehicleTypeDB();
            VehicleTypeList vehicletype = db.SelectAll();
            return vehicletype;
        }

//----------------------------------------------------------------------------------------------------
        [HttpPost]
        public int InsertACity(Cities city)
        {
            CitiesDB db = new CitiesDB();
            db.Insert(city);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertACourier(Couriers courier)
        {
            CouriersDB db = new CouriersDB();
            db.Insert(courier);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertADelivery(Deliveries delivery)
        {
            DeliveriesDB db = new DeliveriesDB();
            db.Insert(delivery);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAnItemInMenu(ItemsInMenu iteminmenu)
        {
            ItemsInMenuDB db = new ItemsInMenuDB();
            db.Insert(iteminmenu);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAMenu(Menus menu)
        {
            MenusDB db = new MenusDB();
            db.Insert(menu);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAnOrderItem(OrderItems orderitem)
        {
            OrderItemsDB db = new OrderItemsDB();
            db.Insert(orderitem);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAnOrder(Orders order)
        {
            OrdersDB db = new OrdersDB();
            db.Insert(order);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertARestaurant(Restaurants restaurant)
        {
            RestaurantsDB db = new RestaurantsDB();
            db.Insert(restaurant);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAUser(Users user)
        {
            UsersDB db = new UsersDB();
            db.Insert(user);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAVehicleType(VehicleType vehicletype)
        {
            VehicleTypeDB db = new VehicleTypeDB();
            db.Insert(vehicletype);
            int x = db.SaveChanges();
            return x;
        }

//----------------------------------------------------------------------------------------------------

        [HttpPut]
        public int UpdateACity([FromBody] Cities city)
        {
            CitiesDB db = new CitiesDB();
            db.Update(city);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateACourier([FromBody] Couriers courier)
        {
            CouriersDB db = new CouriersDB();
            db.Update(courier);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateADelivery([FromBody] Deliveries delivery)
        {
            DeliveriesDB db = new DeliveriesDB();
            db.Update(delivery);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAnItemInMenu([FromBody] ItemsInMenu iteminmenu)
        {
            ItemsInMenuDB db = new ItemsInMenuDB();
            db.Update(iteminmenu);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAMenu([FromBody] Menus menu)
        {
            MenusDB db = new MenusDB();
            db.Update(menu);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAnOrderItem([FromBody] OrderItems orderitem)
        {
            OrderItemsDB db = new OrderItemsDB();
            db.Update(orderitem);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAnOrder([FromBody] Orders order)
        {
            OrdersDB db = new OrdersDB();
            db.Update(order);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateARestaurant([FromBody] Restaurants restaurant)
        {
            RestaurantsDB db = new RestaurantsDB();
            db.Update(restaurant);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAnUser([FromBody] Users user)
        {
            UsersDB db = new UsersDB();
            db.Update(user);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPut]
        public int UpdateAVehicleType([FromBody] VehicleType vehicletype)
        {
            VehicleTypeDB db = new VehicleTypeDB();
            db.Update(vehicletype);
            int x = db.SaveChanges();
            return x;
        }

//----------------------------------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public int DeleteACity(int id)
        {
            Cities city = (new CitiesDB().SelectAll()).Find(x => x.Id == id);
            CitiesDB db = new CitiesDB();
            db.Delete(city);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteACouriers(int id)
        {
            Couriers courier = (new CouriersDB().SelectAll()).Find(x => x.Id == id);
            CouriersDB db = new CouriersDB();
            db.Delete(courier);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteADeliveries(int id)
        {
            Deliveries delivery = (new DeliveriesDB().SelectAll()).Find(x => x.Id == id);
            DeliveriesDB db = new DeliveriesDB();
            db.Delete(delivery);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAnItemInMenu(int id)
        {
            ItemsInMenu iteminmenu = (new ItemsInMenuDB().SelectAll()).Find(x => x.Id == id);
            ItemsInMenuDB db = new ItemsInMenuDB();
            db.Delete(iteminmenu);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAMenu(int id)
        {
            Menus menu = (new MenusDB().SelectAll()).Find(x => x.Id == id);
            MenusDB db = new MenusDB();
            db.Delete(menu);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAnOrderItem(int id)
        {
            OrderItems orderitem = (new OrderItemsDB().SelectAll()).Find(x => x.Id == id);
            OrderItemsDB db = new OrderItemsDB();
            db.Delete(orderitem);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAnOrder(int id)
        {
            Orders order = (new OrdersDB().SelectAll()).Find(x => x.Id == id);
            OrdersDB db = new OrdersDB();
            db.Delete(order);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteARestaurant(int id)
        {
            Restaurants restaurant = (new RestaurantsDB().SelectAll()).Find(x => x.Id == id);
            RestaurantsDB db = new RestaurantsDB();
            db.Delete(restaurant);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAUser(int id)
        {
            Users user = (new UsersDB().SelectAll()).Find(x => x.Id == id);
            UsersDB db = new UsersDB();
            db.Delete(user);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAVehicleType(int id)
        {
            VehicleType vehicletype = (new VehicleTypeDB().SelectAll()).Find(x => x.Id == id);
            VehicleTypeDB db = new VehicleTypeDB();
            db.Delete(vehicletype);
            int x = db.SaveChanges();
            return x;
        }
//----------------------------------------------------------------------------------------------------

    }
}