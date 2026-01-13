using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class OrdersDB : BaseDB
    {
        public OrdersList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Orders";
            OrdersList pList = new OrdersList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Orders o = entity as Orders;
            o.UserId = UsersDB.SelectById((int)reader["UserId"]);
            o.RestaurantId = RestaurantsDB.SelectById((int)reader["RestaurantId"]);
            o.EstimatedTime = int.Parse(reader["estimatedTime"].ToString());
            base.CreateModel(entity);
            return o;
        }
        public override BaseEntity NewEntity()
        {
            return new Orders();
        }
        static private OrdersList list = new OrdersList();
        public static Orders SelectById(int id)
        {
            OrdersDB db = new OrdersDB();
            list = db.SelectAll();

            Orders g = list.Find(item => item.Id == id);
            return g;
        }




        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Orders o = entity as Orders;
            if (o != null)
            {
                string sqlStr = $"DELETE FROM Orders where id=@oid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oid", o.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Orders o = entity as Orders;
            if (o != null)
            {
                string sqlStr = $"Insert INTO  Orders (UserId,RestaurantId,EstimatedTime)" +
                    $" VALUES (@oUserId,@oRestaurantId,@oEstimatedTime)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oUserId", o.UserId.Id));
                command.Parameters.Add(new OleDbParameter("@oRestaurantId", o.RestaurantId.Id));
                command.Parameters.Add(new OleDbParameter("@oEstimatedTime", o.EstimatedTime));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Orders o = entity as Orders;
            if (o != null)
            {
                string sqlStr = $"UPDATE Orders  SET UserId=@oUserId , " +
                 $"RestaurantId=@oRestaurantId , EstimatedTime=@oEstimatedTime WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oUserId", o.UserId.Id));
                command.Parameters.Add(new OleDbParameter("@oRestaurantId", o.RestaurantId.Id));
                command.Parameters.Add(new OleDbParameter("@oEstimatedTime", o.EstimatedTime));
                command.Parameters.Add(new OleDbParameter("@id", o.Id));
            }
        }
    }
}