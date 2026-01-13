using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ItemsInMenuDB : BaseDB
    {
        public ItemsInMenuList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ItemsInMenu";
            ItemsInMenuList pList = new ItemsInMenuList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ItemsInMenu i = entity as ItemsInMenu;
            i.MenuId = MenusDB.SelectById((int)reader["MenuId"]);
            i.Name = reader["name"].ToString();
            i.Price = double.Parse(reader["price"].ToString());
            base.CreateModel(entity);
            return i;
        }
        public override BaseEntity NewEntity()
        {
            return new ItemsInMenu();
        }
        static private ItemsInMenuList list = new ItemsInMenuList();
        public static ItemsInMenu SelectById(int id)
        {
            ItemsInMenuDB db = new ItemsInMenuDB();
            list = db.SelectAll();

            ItemsInMenu g = list.Find(item => item.Id == id);
            return g;
        }




        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ItemsInMenu i = entity as ItemsInMenu;
            if (i != null)
            {
                string sqlStr = $"DELETE FROM ItemsInMenu where id=@iid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@iid", i.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ItemsInMenu i = entity as ItemsInMenu;
            if (i != null)
            {
                string sqlStr = $"Insert INTO  Couriers (MenuId,Name,Price) " +
                    $"VALUES (@iMenuId,@iName,@iPrice)";

                command.Parameters.Add(new OleDbParameter("@iMenuId", i.MenuId.Id));
                command.Parameters.Add(new OleDbParameter("@iName", i.Name));
                command.Parameters.Add(new OleDbParameter("@iPrice", i.Price));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ItemsInMenu i = entity as ItemsInMenu;
            if (i != null)
            {
                string sqlStr = $"UPDATE ItemsInMenu  SET MenuId=@iMenuId , " +
                    $"Name=@iName , iPrice=@iPrice WHERE ID=@id";

                command.Parameters.Add(new OleDbParameter("@iMenuId", i.MenuId.Id));
                command.Parameters.Add(new OleDbParameter("@iName", i.Name));
                command.Parameters.Add(new OleDbParameter("@iPrice", i.Price));
                command.Parameters.Add(new OleDbParameter("@id", i.Id));
            }

        }

    }
}