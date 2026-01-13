using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Users : BaseEntity
    {
        private Cities cityID;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string phoneNumber;
        private DateTime birthDate;

        public Cities CityID { get => cityID; set => cityID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
    }
}
