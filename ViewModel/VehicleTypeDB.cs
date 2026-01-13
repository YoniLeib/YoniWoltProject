using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class VehicleTypeDB : BaseDB
    {
        public VehicleTypeList SelectAll()
        {
            command.CommandText = $"SELECT * FROM VehicleType";
            VehicleTypeList pList = new VehicleTypeList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            VehicleType v = entity as VehicleType;
            v.Name = reader["name"].ToString();
            v.MaxCapacity = int.Parse(reader["maxCapacity"].ToString());
            v.Speed = int.Parse(reader["speed"].ToString());
            base.CreateModel(entity);
            return v;
        }
        public override BaseEntity NewEntity()
        {
            return new VehicleType();
        }
        static private VehicleTypeList list = new VehicleTypeList();
        public static VehicleType SelectById(int id)
        {
            VehicleTypeDB db = new VehicleTypeDB();
            list = db.SelectAll();

            VehicleType g = list.Find(item => item.Id == id);
            return g;
        }




        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            VehicleType v = entity as VehicleType;
            if (v != null)
            {
                string sqlStr = $"DELETE FROM VehicleType where id=@vid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@vid", v.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            VehicleType v = entity as VehicleType;
            if (v != null)
            {
                string sqlStr = $"Insert INTO  PersonTbl (Name,MaxCapacity,Speed) " +
                $"VALUES (@@vName,@vMaxCapacity,@vSpeed)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@vName", v.Name));
                command.Parameters.Add(new OleDbParameter("@vMaxCapacity", v.MaxCapacity));
                command.Parameters.Add(new OleDbParameter("@vSpeed", v.Speed));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            VehicleType v = entity as VehicleType;
            if (v != null)
            {
                string sqlStr = $"UPDATE VehicleType  SET Name=@vName , " +
                    $"MaxCapacity=@vMaxCapacity , Speed=@vSpeed WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@vName", v.Name));
                command.Parameters.Add(new OleDbParameter("@vMaxCapacity", v.MaxCapacity));
                command.Parameters.Add(new OleDbParameter("@vSpeed", v.Speed));
                command.Parameters.Add(new OleDbParameter("@id", v.Id));
            }
        }
    }
}