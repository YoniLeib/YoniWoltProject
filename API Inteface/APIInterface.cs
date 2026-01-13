using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;

namespace API_Inteface
{
    public interface APIInterface
    {

        public Task<CitiesList> GetAllCities();
        public Task<int> InsertCities(Cities city);
        public Task<int> UpdateCities(Cities city); 
        public Task<int> DeleteCities(int id); 

        public Task<CouriersList> GetAllCouries();
        public Task<int> InsertCouries(Couriers courier);
        public Task<int> UpdateCouries(Couriers courier);
        public Task<int> DeleteCouries(int id);
        
        public Task <DeliveriesList> GetAllDeliveries();
        public Task<int> InsertDeliveries(Deliveries delivery);
        public Task<int> UpdateDeliveries(Deliveries delivery);
        public Task<int> DeleteDeliveries(int id);
       
        public Task<ItemsInMenuList> GetAllItemsInMenu();
        public Task<int> InsertItemsInMenu(ItemsInMenu itemsinmenu);
        public Task<int> UpdateItemsInMenu(ItemsInMenu itemsinmenu);
        public Task<int> DeleteItemsInMenu(int id);
        
        public Task<MenusList> GetAllMenus();
        public Task<int> InsertMenus(Menus menu);
        public Task<int> UpdateMenus(Menus menu);
        public Task<int> DeleteMenus(int id);

        public Task<OrdersList> GetAllOrders();
        public Task<int> InsertOrders(Orders order);
        public Task<int> UpdateOrders(Orders order);
        public Task<int> DeleteOrders(int id);

        public Task<OrderItemsList>GetAllOrderItems();
        public Task<int> InsertOrderItems(OrderItems orderitem);
        public Task<int> UpdateOrderItems(OrderItems orderitem);
        public Task<int> DeleteOrderItems(int id);

        public Task<RestaurantsList> GetAllRestaurants();
        public Task<int> InsertRestaurants(Restaurants restaurant);
        public Task<int> UpdateRestaurants(Restaurants restaurant);
        public Task<int> DeleteRestaurants(int id);  

        public Task<UsersList> GetAllUsers();
        public Task<int> InsertUsers(Users user);
        public Task<int> UpdateUsers(Users user);
        public Task<int> DeleteUsers(int id);

        public Task <VehicleTypeList> GetAllVehicleTypes();
        public Task<int> InsertVehicleTypes(VehicleType vehicletype);
        public Task<int> UpdateVehicleTypes(VehicleType vehicletype);
        public Task<int> DeleteVehicleTypes(int id);

    }
}
