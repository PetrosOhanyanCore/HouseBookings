using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Payment
    {
        public int Id { get; set; }

        public decimal? Amount { get; set; }

        public Currencies Code { get; set; }

        public int CardNumber { get; set; }

    
        public int CardExpireMonth { get; set; }

        public int CardExpireYear { get; set; }

        
        public string CardOwner { get; set; }

        
        public short CVV { get; set; }

    
        public DateTime PaymentDate { get; set; }

        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }

    public enum Currencies
    {
        USD = 1, // Dollar USA
        EUR = 2, // Euro
        GBP = 3, // Pound-Sterling
        JPY = 4 // Japan Iyen
             // others
    }
}
