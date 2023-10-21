using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public decimal? Amount { get; set; }

        [Required]
        public Currency CurrencyCode { get; set; }

        [Required]
        [StringLength(16)]
        public int CardNumber { get; set; }

        [Required]
        [Range(1, 12)]
        public int CardExpireMonth { get; set; }

        [Required]
        [StringLength(2)]
        public int CardExpireYear { get; set; }

        [Required]
        public string CardOwner { get; set; }

        [MinLength(3), MaxLength(4)]
        public short CVV { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PaymentDate { get; set; }

        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }

    public enum Currency
    {
        USD, // Dollar USA
        EUR, // Euro
        GBP, // Pound-Sterling
        JPY, // Japan Iyen
             // others
    }
}
