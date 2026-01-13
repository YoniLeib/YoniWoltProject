using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MenusDB : BaseDB
    {
        public MenusList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Menus";
            MenusList pList = new MenusList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Menus m = entity as Menus;
            m.Title = reader["title"].ToString();
            m.RestaurantId = RestaurantsDB.SelectById((int)reader["RestaurantId"]);

            base.CreateModel(entity);
            return m;
        }
        public override BaseEntity NewEntity()
        {
            return new Menus();
        }
        static private MenusList list = new MenusList();
        public static Menus SelectById(int id)
        {
            MenusDB db = new MenusDB();
            list = db.SelectAll();

            Menus g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Menus m = entity as Menus;
            if (m != null)
            {
                string sqlStr = $"DELETE FROM Menus where id=@mid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@mid", m.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Menus m = entity as Menus;
            if (m != null)
            {
                string sqlStr = $"Insert INTO  Menus (Title,RestaurantId) " +
                    $"VALUES (@mTitle,@mRestaurantId)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@mTitle", m.Title));
                command.Parameters.Add(new OleDbParameter("@mRestaurantId", m.RestaurantId.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Menus m = entity as Menus;
            if (m != null)
            {
                string sqlStr = $"UPDATE Menus  SET Title=@mTitle , " +
                    $"RestaurantId=@mRestaurantId  WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@mTitle", m.Title));
                command.Parameters.Add(new OleDbParameter("@mRestaurantId", m.RestaurantId.Id));
                command.Parameters.Add(new OleDbParameter("@mid", m.Id));
            }
        }

    }
}