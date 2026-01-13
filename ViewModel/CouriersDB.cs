using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CouriersDB : BaseDB
    {
        public CouriersList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Couriers";
            CouriersList pList = new CouriersList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Couriers c = entity as Couriers;
            c.VehicleTypeId = VehicleTypeDB.SelectById((int)reader["VehicleTypeID"]);
            c.FirstName = reader["firstName"].ToString();
            c.LastName = reader["lastName"].ToString();
            c.BirthDate = (DateTime)reader["birthDate"];
            c.Salary = int.Parse(reader["salary"].ToString());
            c.IsAvailable = (bool)reader["isAvailable"];
            base.CreateModel(entity);
            return c;
        }
        public override BaseEntity NewEntity()
        {
            return new Couriers();
        }
        static private CouriersList list = new CouriersList();
        public static Couriers SelectById(int id)
        {
            CouriersDB db = new CouriersDB();
            list = db.SelectAll();

            Couriers g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Couriers c = entity as Couriers;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Couriers where id=@cid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Couriers c = entity as Couriers;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  Couriers (VehicleTypeId,FirstName,LastName,BirthDate,Salary,IsAvailable) " +
                    $"VALUES (@cVehicleTypeId,@cFirstName,@cLastName,@cBirthDate,@cSalary,@cIsAvailable)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cVehicleTypeId", c.VehicleTypeId.Id));
                command.Parameters.Add(new OleDbParameter("@cFirstName", c.FirstName));
                command.Parameters.Add(new OleDbParameter("@cLastName", c.LastName));
                command.Parameters.Add(new OleDbParameter("@cBirthDate", c.BirthDate));
                command.Parameters.Add(new OleDbParameter("@cSalary", c.Salary));
                command.Parameters.Add(new OleDbParameter("@cIsAvailable", c.IsAvailable));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Couriers c = entity as Couriers;
            if (c != null)
            {
                string sqlStr = $"UPDATE Couriers  SET VehicleTypeId=@cVehicleTypeID , " +
                    $"FirstName=@cFirstName , LastName=@cLastName , " +
                    $"BirthDate=@cBirthDate , Salary=@cSalary , " +
                    $"IsAvailable=@cIsAvailable WHERE ID=@id" ;

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cVehicleTypeID", c.VehicleTypeId.Id));
                command.Parameters.Add(new OleDbParameter("@cFirstName", c.FirstName));
                command.Parameters.Add(new OleDbParameter("@cLastName", c.LastName));
                command.Parameters.Add(new OleDbParameter("@cBirthDate", c.BirthDate));
                command.Parameters.Add(new OleDbParameter("@cSalary", c.Salary));
                command.Parameters.Add(new OleDbParameter("@cIsAvailable", c.IsAvailable));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}