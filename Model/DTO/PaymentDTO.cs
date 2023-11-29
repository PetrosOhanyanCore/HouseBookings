
using Entity;
using System.ComponentModel.DataAnnotations;

namespace Model.DTO
{
    public class PaymentDTO
    {
        public int Id { get; set; }

        public decimal? Amount { get; set; }

        public Currencies CurrencyCode { get; set; }

        public string CardNumber { get; set; }

        public int CardExpireMonth { get; set; }

        public string CardExpireYear { get; set; }

        public string CardOwner { get; set; }

        public short CVV { get; set; }

        public DateTime PaymentDate { get; set; }

        public int BookingId { get; set; }
        public BookingDTO Booking { get; set; }
    }
}
