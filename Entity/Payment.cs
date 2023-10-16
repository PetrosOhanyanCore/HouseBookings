using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    namespace Entity
    {

        public class Payment
        {
            [Key]
            public int PaymentId { get; set; }

            [Required]
            public decimal Amount { get; set; }

            [Required]
            public Currency CurrencyCode { get; set; }

            [Required]
            [StringLength(16, MinimumLength = 16)]
            public int CardNumber { get; set; }

            [Required]
            public string CardOwner { get; set; }

            [Range(100, 999)]
            public short CVV { get; set; }

            [Required]
            [DataType(DataType.DateTime)]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public DateTime PaymentDate { get; set; }

            //public int BookingId { get; set; }

            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int OrderId { get; set; }

            public Payment()
            {

            }
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
}
