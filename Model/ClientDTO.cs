
using Entity;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Translation Translation { get; set; }
        public DateTime? BirthDate { get; set; }
        public Address LivingAddress { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Scoring> Scorings { get; set; }
    }
}

