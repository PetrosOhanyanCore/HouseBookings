
using Entity;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class PaymentDTO
    {
        public int Id { get; set; }

        public decimal? Amount { get; set; }

        [Required(ErrorMessage = "Currency Code is required.")]
        public Currency CurrencyCode { get; set; }

        [Required(ErrorMessage = "Card Number is required.")]
        [StringLength(16, ErrorMessage = "Card Number must be between 1 and 16 characters.")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Card Expiry Month is required.")]
        [Range(1, 12, ErrorMessage = "Card Expiry Month must be between 1 and 12.")]
        public int CardExpireMonth { get; set; }

        [Required(ErrorMessage = "Card Expiry Year is required.")]
        [StringLength(2, ErrorMessage = "Card Expiry Year must be 2 characters.")]
        public string CardExpireYear { get; set; }

        [Required(ErrorMessage = "Card Owner is required.")]
        public string CardOwner { get; set; }

        [MinLength(3, ErrorMessage = "CVV must be at least 3 characters.")]
        [MaxLength(4, ErrorMessage = "CVV cannot be longer than 4 characters.")]
        public short CVV { get; set; }

        [Required(ErrorMessage = "Payment Date is required.")]
        [DataType(DataType.DateTime, ErrorMessage = "Payment Date must be a valid date.")]
        public DateTime PaymentDate { get; set; }

        public int BookingId { get; set; }
        // public BookingDto Booking { get; set; }}
    }

}
