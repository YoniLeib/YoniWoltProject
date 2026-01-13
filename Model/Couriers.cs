using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Couriers : BaseEntity
    {

        private VehicleType vehicleTypeId;
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private int salary;
        private bool isAvailable;

        public VehicleType VehicleTypeId { get => vehicleTypeId; set => vehicleTypeId = value; }

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public DateTime BirthDate { get => birthDate; set => birthDate = value; }

        public int Salary { get => salary; set => salary = value; }

        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }
    }
}
