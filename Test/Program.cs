using Model;
using ViewModel;
using API_Inteface;
using API_project;

//--------------------------------------------------------------------//

//CitiesDB ctdb = new();
//CitiesList ctList = ctdb.SelectAll();
//foreach (Cities ct in ctList)
//    Console.WriteLine(ct.CityName);

//Cities cityToUpdate = ctList[0];
//cityToUpdate.CityName += "אאא";
//ctdb.Update(cityToUpdate);
//int x = ctdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

//Cities new_city = new Cities { CityName = "sderot" };
//ctdb.Insert(new_city);
//int y = ctdb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//ctdb.Delete(ctList.Last());
//int z = ctdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

//CouriersDB cdb = new();
//CouriersList cList = cdb.SelectAll();
//foreach (Couriers co in cList)
//{

//    Console.WriteLine(co.FirstName);
//    Console.WriteLine(co.LastName);
//    Console.WriteLine(co.BirthDate);
//    Console.WriteLine(co.Salary);
//    Console.WriteLine(co.IsAvailable);
//}

//Couriers couriersToUpdate = cList.First();
//couriersToUpdate.BirthDate = couriersToUpdate.BirthDate.AddYears(-1);
//cdb.Update(couriersToUpdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

//VehicleTypeDB vdb = new();
//VehicleTypeList vList = vdb.SelectAll();
//Couriers new_couriers = new Couriers { VehicleTypeId = vList[0], FirstName = "aviel", LastName = "belay", BirthDate = new DateTime(2023, 05, 06), Salary = 100, IsAvailable = true };
//cdb.Insert(new_couriers);
//int y = cdb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//cdb.Delete(cList.Last());
//int z = cdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

//DeliveriesDB ddb = new();
//DeliveriesList dList = ddb.SelectAll();
//foreach (Deliveries d in dList)
//{
//    Console.WriteLine(d.Status);
//    Console.WriteLine(d.DeliveryDate);
//}

//Deliveries DeliveriesToUpdate = dList.First();
//DeliveriesToUpdate.DeliveryDate = DeliveriesToUpdate.DeliveryDate.AddMonths(-1);
//ddb.Update(DeliveriesToUpdate);
//int x = ddb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

//CityDB ctdb = new();
//CityList ctList = ctdb.SelectAll();
//CouriersDB cdb = new();
//CouriersList cList = cdb.SelectAll();
//Deliveries new_deliveries = new Deliveries { CityId = ctList[0], CourierId = cList[0], Status = "ready", DeliveryDate = new DateTime(2005, 05, 05) };
//ddb.Insert(new_deliveries);
//int y = ddb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//ddb.Delete(dList.Last());
//int z = ddb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

//ItemsInMenuDB idb = new();
//ItemsInMenuList iList = idb.SelectAll();
//foreach (ItemsInMenu i in iList)
//{
//    Console.WriteLine(i.Name);
//    Console.WriteLine(i.Price);
//}

//ItemsInMenu ItemsInMenuToUpdate = iList.First();
//ItemsInMenuToUpdate.Price = ItemsInMenuToUpdate.Price * 0.9;
//idb.Update(ItemsInMenuToUpdate);
//int x = idb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

//MenusDB mdb = new();
//MenusList mList = mdb.SelectAll();
//ItemsInMenu new_itemsInMenu = new ItemsInMenu { MenuId = mList[0], Name = "Lemon", Price = 50 };
//idb.Insert(new_itemsInMenu);
//int y = idb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//idb.Delete(iList.Last());
//int z = idb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

//MenusDB mdb = new();
//MenusList mList = mdb.SelectAll();
//foreach (Menus m in mList)
//{
//    Console.WriteLine(m.Title);
//}

//Menus MenusToUpdate = mList.First();
//MenusToUpdate.Title += "אאא";
//ddb.Update(MenusToUpdate);
//int x = ddb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");


//Menus new_menus = new Menus { Title = "soho", RestaurantId = rList[0] };
//ddb.Insert(new_menus);
//int y = ddb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//ddb.Delete(mList.Last());
//int z = ddb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

//OrdersDB odb = new();
//OrdersList oList = odb.SelectAll();
//foreach (Orders o in oList)
//{
//    Console.WriteLine(o.EstimatedTime);
//}

//Orders OrdersToUpdate = oList.First();
//OrdersToUpdate.EstimatedTime += 30;
//odb.Update(OrdersToUpdate);
//int x = odb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

//UsersDB udb = new();
//UsersList uList = udb.SelectAll();
//RestaurantsDB rdb = new();
//RestaurantsList rList = rdb.SelectAll();
//Orders new_orders = new Orders { UserId = uList[0], RestaurantId = rList[0] , EstimatedTime = 30};
//odb.Insert(new_orders);
//int y = odb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//odb.Delete(oList.Last());
//int z = odb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

//OrderItemsDB oidb = new();
//OrderItemsList oiList = oidb.SelectAll();
//foreach (OrderItems oi in oiList)
//{

//    Console.WriteLine(oi.Quantity);
//}

//OrderItems OrderItemsToUpdate = oiList.First();
//OrderItemsToUpdate.Quantity *= 2;
//oidb.Update(OrderItemsToUpdate);
//int x = oidb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

//ItemsInMenuDB idb = new();
//ItemsInMenuList iList = idb.SelectAll();
//OrdersDB odb = new();
//OrdersList oList = odb.SelectAll();
//OrderItems new_orderItems = new OrderItems { ItemID = iList[0], OrderID = oList[0], Quantity = 10 };
//oidb.Insert(new_orderItems);
//int y = oidb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//oidb.Delete(oList.Last());
//int z = oidb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

//RestaurantsDB rdb = new();
//RestaurantsList rList = rdb.SelectAll();
//foreach (Restaurants r in rList)
//{
//    Console.WriteLine(r.Name);
//    Console.WriteLine(r.OpenTime);
//    Console.WriteLine(r.CloseTime);
//}

//Restaurants RestaurantsToUpdate = rList.First();
//RestaurantsToUpdate.CloseTime = RestaurantsToUpdate.CloseTime.AddHours(1);
//rdb.Update(RestaurantsToUpdate);
//int x = rdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

//CityDB ctdb = new();
//CityList ctList = ctdb.SelectAll();
//Restaurants new_Restaurants = new Restaurants { CityId = ctList[0], Name = "soho", OpenTime = new DateTime(2005, 05, 05), CloseTime = new DateTime(2005, 05, 05) };
//rdb.Insert(new_Restaurants);
//int y = rdb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//rdb.Delete(rList.Last());
//int z = rdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

//UsersDB udb = new();
//UsersList uList = udb.SelectAll();
//foreach (Users u in uList)
//{
//    Console.WriteLine(u.FirstName);
//    Console.WriteLine(u.LastName);
//    Console.WriteLine(u.PhoneNumber);
//    Console.WriteLine(u.Email);
//    Console.WriteLine(u.BirthDate);
//}

//Users UsersToUpdate = uList.First();
//UsersToUpdate.FirstName += "אאא";
//udb.Update(UsersToUpdate);
//int x = udb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

//CityDB ctdb = new();
//CityList ctList = ctdb.SelectAll();
//Users new_users = new Users { CityID = ctList[0], FirstName = "aviel", LastName = "belay", PhoneNumber = 0523740471, Email = "abcd@gmail.com", BirthDate = new DateTime(2005, 05, 05) };
//udb.Insert(new_users);
//int y = udb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//udb.Delete(uList.Last());
//int z = udb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

//VehicleTypeDB vdb = new();
//VehicleTypeList vList = vdb.SelectAll();
//foreach (VehicleType v in vList)
//{
//    Console.WriteLine(v.Name);
//    Console.WriteLine(v.MaxCapacity);
//    Console.WriteLine(v.Speed);
//}

//VehicleType VehicleTypeToUpdate = vList.First();
//VehicleTypeToUpdate.Speed += 10;
//vdb.Update(VehicleTypeToUpdate);
//int x = vdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

//VehicleType new_vehicleType = new VehicleType { Name = "car", MaxCapacity = 4 , Speed = 250 };
//vdb.Insert(new_vehicleType);
//int y = vdb.SaveChanges();
//Console.WriteLine($"{y} rows were inserted");

//vdb.Delete(vList.Last());
//int z = vdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//--------------------------------------------------------------------//

ApiService apiService = new ApiService();

CitiesList d = await apiService.GetAllCities();

foreach (Cities city in d)
{
    await Console.Out.WriteLineAsync(city.CityName);
}

//--------------------------------------------------------------------//
