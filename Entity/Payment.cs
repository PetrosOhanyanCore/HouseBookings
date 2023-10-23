using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Payment
    {
        public int Id { get; set; }

        public decimal? Amount { get; set; }

        public Currency CurrencyCode { get; set; }

        public int CardNumber { get; set; }

    
        public int CardExpireMonth { get; set; }

        public int CardExpireYear { get; set; }

        
        public string CardOwner { get; set; }

        
        public short CVV { get; set; }

    
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
