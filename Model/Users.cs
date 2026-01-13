using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Users : BaseEntity
    {
        private City cityID;
        private string firstName;
        private string lastName;
        private string email;
        private int phoneNumber;
        private DateTime birthDate;

        public City CityID { get => cityID; set => cityID = value; }
        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public string Email { get => email; set => email = value; }

        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
    }
}
