
using Entity;
using System.ComponentModel.DataAnnotations;

namespace Model.DTO
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public TranslationDTO Translation { get; set; }
        public DateTime? BirthDate { get; set; }
        public AddressDTO LivingAddress { get; set; }
        public ICollection<ApartmentDTO> Apartments { get; set; }
        public ICollection<BookingDTO> Bookings { get; set; }
        public ICollection<ScoringDTO> Scorings { get; set; }
    }
}

