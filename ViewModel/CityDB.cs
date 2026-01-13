using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CityDB : BaseDB
    {
        public CityList SelectAll()
        {
            command.CommandText = $"SELECT * FROM City";
            CityList groupList = new CityList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            City ct = entity as City;
            ct.CityName = reader["cityName"].ToString();
            base.CreateModel(entity);
            return ct;
        }
        public override BaseEntity NewEntity()
        {
            return new City();
        }
        static private CityList list = new CityList();

        public static City SelectById(int id)
        {
            CityDB db = new CityDB();
            list = db.SelectAll();

            City g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            City ct = entity as City;
            if (ct != null)
            {
                string sqlStr = $"DELETE FROM City where id=@ctid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ctid", ct.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            City ct = entity as City;
            if (ct != null)
            {
                string sqlStr = $"Insert INTO  City (CityName) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ctName", ct.CityName));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            City ct = entity as City;
            if (ct != null)
            {
                string sqlStr = $"UPDATE City  SET CityName=@ctCityName WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ctCityName", ct.CityName));
                command.Parameters.Add(new OleDbParameter("@id", ct.Id));
            }
        }
    }
}