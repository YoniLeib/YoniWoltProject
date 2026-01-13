using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CitiesDB : BaseDB
    {
        public CitiesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Cities";
            CitiesList groupList = new CitiesList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Cities ct = entity as Cities;
            ct.CityName = reader["cityName"].ToString();
            base.CreateModel(entity);
            return ct;
        }
        public override BaseEntity NewEntity()
        {
            return new Cities();
        }
        static private CitiesList list = new CitiesList();

        public static Cities SelectById(int id)
        {
            CitiesDB db = new CitiesDB();
            list = db.SelectAll();

            Cities g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cities ct = entity as Cities;
            if (ct != null)
            {
                string sqlStr = $"DELETE FROM Cities where id=@ctid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ctid", ct.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cities ct = entity as Cities;
            if (ct != null)
            {
                string sqlStr = $"Insert INTO  Cities (CityName) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ctName", ct.CityName));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cities ct = entity as Cities;
            if (ct != null)
            {
                string sqlStr = $"UPDATE Cities  SET CityName=@ctCityName WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ctCityName", ct.CityName));
                command.Parameters.Add(new OleDbParameter("@id", ct.Id));
            }
        }
    }
}