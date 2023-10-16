using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Translation Translation { get; set; }

        public DateTime? BirthDate { get; set; }
        public int? LivingAddressId { get; set; }
        public Address LivingAddress { get; set; }
        public ICollection<Apartment> Apartments { get; set; }


    }
}
