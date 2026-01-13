using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UsersDB : BaseDB
    {
        public UsersList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Users";
            UsersList pList = new UsersList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Users u = entity as Users;
            u.CityID = CitiesDB.SelectById((int)reader["CityID"]);
            u.FirstName = reader["firstName"].ToString();
            u.LastName = reader["lastName"].ToString();
            u.Email = reader["email"].ToString();
            u.Password = reader["Password"].ToString();
            u.PhoneNumber = reader["phoneNumber"].ToString();
            u.BirthDate = (DateTime)reader["birthDate"];
            base.CreateModel(entity);
            return u;
        }
        public override BaseEntity NewEntity()
        {
            return new Users();
        }
        static private UsersList list = new UsersList();
        public static Users SelectById(int id)
        {
            UsersDB db = new UsersDB();
            list = db.SelectAll();

            Users g = list.Find(item => item.Id == id);
            return g;
        }




        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = $"DELETE FROM Users where id=@uid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uid", u.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = $"Insert INTO  Users (CityID,FirstName,LastName,PhoneNumber,Email,BirthDate) " +
                $"VALUES (@uCityID,@uFirstName,@uLastName,@uPhoneNumber,@uEmail,@uBirthDate)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uCityID", u.CityID.Id));
                command.Parameters.Add(new OleDbParameter("@uFirstName", u.FirstName));
                command.Parameters.Add(new OleDbParameter("@uLastName", u.LastName));
                command.Parameters.Add(new OleDbParameter("@uPhoneNumber", u.PhoneNumber));
                command.Parameters.Add(new OleDbParameter("@uEmail", u.Email));
                command.Parameters.Add(new OleDbParameter("@uPassword", u.Password));
                command.Parameters.Add(new OleDbParameter("@uBirthDate", u.BirthDate));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = $"UPDATE Users  SET CityID=@uCityID , " +
                $"FirstName=@uFirstName , LastName=@uLastName , " +
                $"PhoneNumber=@uPhoneNumber ,Email=@uEmail , Password=@uPassword" +
                $"BirthDate=@uBirthDate WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uCityID", u.CityID.Id));
                command.Parameters.Add(new OleDbParameter("@uFirstName", u.FirstName));
                command.Parameters.Add(new OleDbParameter("@uLastName", u.LastName));
                command.Parameters.Add(new OleDbParameter("@uPhoneNumber", u.PhoneNumber));
                command.Parameters.Add(new OleDbParameter("@uEmail", u.Email));
                command.Parameters.Add(new OleDbParameter("@uPassword", u.Password));
                command.Parameters.Add(new OleDbParameter("@uBirthDate", u.BirthDate));
                command.Parameters.Add(new OleDbParameter("@id", u.Id));
            }
        }

    }
}