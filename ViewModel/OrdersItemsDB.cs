using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class OrderItemsDB : BaseDB
    {
        public OrderItemsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM OrderItems";
            OrderItemsList pList = new OrderItemsList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            OrderItems oi = entity as OrderItems;
            oi.ItemID = ItemsInMenuDB.SelectById((int)reader["ItemID"]);
            oi.OrderID = OrdersDB.SelectById((int)reader["OrderID"]);
            oi.Quantity = int.Parse(reader["quantity"].ToString());

            base.CreateModel(entity);
            return oi;
        }
        public override BaseEntity NewEntity()
        {
            return new OrderItems();
        }
        static private OrderItemsList list = new OrderItemsList();
        public static OrderItems SelectById(int id)
        {
            OrderItemsDB db = new OrderItemsDB();
            list = db.SelectAll();

            OrderItems g = list.Find(item => item.Id == id);
            return g;
        }




        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            OrderItems oi = entity as OrderItems;
            if (oi != null)
            {
                string sqlStr = $"DELETE FROM OrderItems where id=@oiid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oiid", oi.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            OrderItems oi = entity as OrderItems;
            if (oi != null)
            {
                string sqlStr = $"Insert INTO  OrderItems (ItemID,OrderID,Quantity) " +
                    $"VALUES (@oiItemID,@oiOrderID,@oiQuantity)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oiItemID", oi.ItemID.Id));
                command.Parameters.Add(new OleDbParameter("@oiOrderID", oi.OrderID.Id));
                command.Parameters.Add(new OleDbParameter("@oiQuantity", oi.Quantity));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            OrderItems oi = entity as OrderItems;
            if (oi != null)
            {
                string sqlStr = $"UPDATE OrderItems  SET ItemID=@oiItemID , " +
                    $"OrderID=@oiOrderID , Quantity=@oiQuantity WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@oiItemID", oi.ItemID.Id));
                command.Parameters.Add(new OleDbParameter("@oiOrderID", oi.OrderID.Id));
                command.Parameters.Add(new OleDbParameter("@oiQuantity", oi.Quantity));
                command.Parameters.Add(new OleDbParameter("@id", oi.Id));
            }
        }
    }
}
