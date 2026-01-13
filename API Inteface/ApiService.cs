using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ViewModel;


namespace API_Inteface
{
    public class ApiService : APIInterface 
    {
        string uri = "http://localhost:5131";
        HttpClient client = new HttpClient();

        public async Task<CitiesList> GetAllCities()
        {
            return await client.GetFromJsonAsync<CitiesList>(uri + "/api/Select/CitiesSelector");
        }

        public async Task<CouriersList> GetAllCouries()
        {
            return await client.GetFromJsonAsync<CouriersList>(uri + "/api/Select/CouriersSelector");
        }

        public async Task<DeliveriesList> GetAllDeliveries()
        {
            return await client.GetFromJsonAsync<DeliveriesList>(uri + "/api/Select/DeliveriesSelector");
        }

        public async Task<ItemsInMenuList> GetAllItemsInMenu()
        {
            return await client.GetFromJsonAsync<ItemsInMenuList>(uri + "/api/Select/ItemsInMenuSelector");
        }

        public async Task<MenusList> GetAllMenus()
        {
            return await client.GetFromJsonAsync<MenusList>(uri + "/api/Select/MenusSelector");
        }

        public async Task<OrderItemsList> GetAllOrderItems()
        {
            return await client.GetFromJsonAsync<OrderItemsList>(uri + "/api/Select/OrderItemsSelector");
        }

        public async Task<OrdersList> GetAllOrders()
        {
            return await client.GetFromJsonAsync<OrdersList>(uri + "/api/Select/OrdersSelector");
        }

        public async Task<RestaurantsList> GetAllRestaurants()
        {
            return await client.GetFromJsonAsync<RestaurantsList>(uri + "/api/Select/RestaurantsSelector");
        }

        public async Task<UsersList> GetAllUsers()
        {
            return await client.GetFromJsonAsync<UsersList>(uri + "/api/Select/UsersSelector");
        }

        public async Task<VehicleTypeList> GetAllVehicleTypes()
        {
            return await client.GetFromJsonAsync<VehicleTypeList>(uri + "/api/Select/VehicleTypeSelector");
        }

        public async Task<int> InsertCities(Cities city)
        {
            return (await client.PostAsJsonAsync<Cities>(uri + "/api/Select/InsertCity", city)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertCouries(Couriers courier)
        {
            return (await client.PostAsJsonAsync<Couriers>(uri + "/api/Select/InsertCourier", courier)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertDeliveries(Deliveries delivery)
        {
            return (await client.PostAsJsonAsync<Deliveries>(uri + "/api/Select/InsertDelivery", delivery)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertItemsInMenu(ItemsInMenu itemsinmenu)
        {
            return (await client.PostAsJsonAsync<ItemsInMenu>(uri + "/api/Select/InsertItemInMenu", itemsinmenu)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertMenus(Menus menu)
        {
            return (await client.PostAsJsonAsync<Menus>(uri + "/api/Select/InsertMenu", menu)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertOrderItems(OrderItems orderitem)
        {
            return (await client.PostAsJsonAsync<OrderItems>(uri + "/api/Select/InsertOrderItem", orderitem)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertOrders(Orders order)
        {
            return (await client.PostAsJsonAsync<Orders>(uri + "/api/Select/InsertOrder", order)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertRestaurants(Restaurants restaurant)
        {
            return (await client.PostAsJsonAsync<Restaurants>(uri + "/api/Select/InsertRestaurant", restaurant)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertUsers(Users user)
        {
            return (await client.PostAsJsonAsync<Users>(uri + "/api/Select/InsertUser", user)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertVehicleTypes(VehicleType vehicletype)
        {
            return (await client.PostAsJsonAsync<VehicleType>(uri + "/api/Select/InsertVehicleType", vehicletype)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateCities(Cities city)
        {
            return (await client.PutAsJsonAsync<Cities>(uri + "/api/Select/UpdateCity", city)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateCouries(Couriers courier)
        {
            return (await client.PutAsJsonAsync<Couriers>(uri + "/api/Select/UpdateCourier", courier)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateDeliveries(Deliveries delivery)
        {
            return (await client.PutAsJsonAsync<Deliveries>(uri + "/api/Select/UpdateDelivery", delivery)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateItemsInMenu(ItemsInMenu itemsinmenu)
        {
            return (await client.PutAsJsonAsync<ItemsInMenu>(uri + "/api/Select/UpdateItemInMenu", itemsinmenu)).IsSuccessStatusCode ? 1 : 0;

        }
        public async Task<int> UpdateMenus(Menus menu)
        {
            return (await client.PutAsJsonAsync<Menus>(uri + "/api/Select/UpdateMenu", menu)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateOrderItems(OrderItems orderitem)
        {
            return (await client.PutAsJsonAsync<OrderItems>(uri + "/api/Select/UpdateOrderItem", orderitem)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateOrders(Orders order)
        {
            return (await client.PutAsJsonAsync<Orders>(uri + "/api/Select/UpdateOrder", order)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateRestaurants(Restaurants restaurant)
        {
            return (await client.PutAsJsonAsync<Restaurants>(uri + "/api/Select/UpdateRestaurant", restaurant)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateUsers(Users user)
        {
            return (await client.PutAsJsonAsync<Users>(uri + "/api/Select/UpdateUser", user)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateVehicleTypes(VehicleType vehicletype)
        {
            return (await client.PutAsJsonAsync<VehicleType>(uri + "/api/Select/UpdateVehicleType", vehicletype)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteCities(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteCity/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteCouries(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteCourier/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteDeliveries(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteDelivery/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteItemsInMenu(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteItemInMenu/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteMenus(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteMenu/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteOrderItems(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteOrderItem/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteOrders(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteOrder/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteRestaurants(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteRestaurant/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteUsers(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteUser/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteVehicleTypes(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteVehicleType/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
    }
}
