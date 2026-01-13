using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class DeliveriesDB : OrdersDB
    {
        public DeliveriesList SelectAll()
        {
            command.CommandText = $"SELECT  Deliveries.Id, Deliveries.CityId, Deliveries.CourierId," +
                $" Deliveries.Status, Deliveries.DeliveryDate, Orders.UserId, Orders.RestaurantId," +
                $" Orders.EstimatedTime FROM (Deliveries INNER JOIN  " +
                $"  Orders ON Deliveries.Id = Orders.Id)";
            DeliveriesList pList = new DeliveriesList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Deliveries d = entity as Deliveries;
            d.CityId = CitiesDB.SelectById((int)reader["cityId"]);
            d.CourierId = CouriersDB.SelectById((int)reader["courierId"]);
            d.Status = reader["status"].ToString();
            d.DeliveryDate = (DateTime)reader["deliveryDate"];
            base.CreateModel(entity);
            return d;
        }
        public override BaseEntity NewEntity()
        {
            return new Deliveries();
        }
        static private DeliveriesList list = new DeliveriesList();

        public static Deliveries SelectById(int id)
        {
            DeliveriesDB db = new DeliveriesDB();
            list = db.SelectAll();

            Deliveries g = list.Find(item => item.Id == id);
            return g;
        }


        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Deliveries d = entity as Deliveries;
            if (d != null)
            {
                string sqlStr = $"DELETE FROM Deliveries where id=@did";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@did", d.Id));
            }
        }
        public override void Delete(BaseEntity entity)
        {
            Deliveries deliveries = entity as Deliveries;
            if (deliveries != null)
            {
                updated.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Deliveries d = entity as Deliveries;
            if (d != null)
            {
                string sqlStr = $"Insert INTO  Deliveries (CityId,CourierId,Status,DeliveryDate) " +
                    $"VALUES (@dCityId,@dCourierId,@dStatus,@dDeliveryDate)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@dCityId", d.CityId.Id));
                command.Parameters.Add(new OleDbParameter("@dCourierId", d.CourierId.Id));
                command.Parameters.Add(new OleDbParameter("@dStatus", d.Status));
                command.Parameters.Add(new OleDbParameter("@dDeliveryDate", d.DeliveryDate));
            }
        }
        public override void Insert(BaseEntity entity)
        {
            Deliveries deliveries = entity as Deliveries;
            if (deliveries != null)
            {
                updated.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
                updated.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
            }
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Deliveries d = entity as Deliveries;
            if (d != null)
            {
                string sqlStr = $"UPDATE Deliveries  SET CityId=@dCityId , " +
                    $"CourierId=@dCourierId , Status=@dStatus , DeliveryDate=@dDeliveryDate WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@dCityId", d.CityId.Id));
                command.Parameters.Add(new OleDbParameter("@dCourierId", d.CourierId.Id));
                command.Parameters.Add(new OleDbParameter("@dStatus", d.Status));
                command.Parameters.Add(new OleDbParameter("@dDeliveryDate", d.DeliveryDate));
                command.Parameters.Add(new OleDbParameter("@id", d.Id));
            }
        }
        public override void Update(BaseEntity entity)
        {
            Deliveries deliveries = entity as Deliveries;
            if (deliveries != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }


    }
}