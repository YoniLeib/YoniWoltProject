using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class RestaurantsDB : BaseDB
    {
        public RestaurantsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Restaurants";
            RestaurantsList pList = new RestaurantsList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Restaurants r = entity as Restaurants;
            r.CityId = CitiesDB.SelectById((int)reader["CityId"]);
            r.Name = reader["name"].ToString();
            r.OpenTime = (DateTime)reader["openTime"];
            r.CloseTime = (DateTime)reader["closeTime"];
            base.CreateModel(entity);
            return r;
        }
        public override BaseEntity NewEntity()
        {
            return new Restaurants();
        }
        static private RestaurantsList list = new RestaurantsList();
        public static Restaurants SelectById(int id)
        {
            RestaurantsDB db = new RestaurantsDB();
            list = db.SelectAll();

            Restaurants g = list.Find(item => item.Id == id);
            return g;
        }



        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Restaurants r = entity as Restaurants;
            if (r != null)
            {
                string sqlStr = $"DELETE FROM Restaurants where id=@rid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@rid", r.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Restaurants r = entity as Restaurants;
            if (r != null)
            {
                string sqlStr = $"Insert INTO  Restaurants (CityId,Name,OpenTimeCloseTime " +
                $"VALUES (@rCityId,@rName,@rOpenTime,@rCloseTime)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@rCityId", r.CityId.Id));
                command.Parameters.Add(new OleDbParameter("@rName", r.Name));
                command.Parameters.Add(new OleDbParameter("@rOpenTime", r.OpenTime));
                command.Parameters.Add(new OleDbParameter("@rCloseTime", r.CloseTime));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Restaurants r = entity as Restaurants;
            if (r != null)
            {
                string sqlStr = $"UPDATE Restaurants  SET CityId=@rCityId ," +
                $"Name=@rName ,OpenTime=@rOpenTime ,CloseTime=@rCloseTime WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@rCityId", r.CityId.Id));
                command.Parameters.Add(new OleDbParameter("@rName", r.Name));
                command.Parameters.Add(new OleDbParameter("@rOpenTime", r.OpenTime));
                command.Parameters.Add(new OleDbParameter("@rCloseTime", r.CloseTime));
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
            }
        }
    }
}