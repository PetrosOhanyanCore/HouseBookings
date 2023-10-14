using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
     public class Payment
        {
            //[Key]
            //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int PaymentId { get; set; }

            [Required]
            public decimal Amount { get; set; }

            [Required]
            public Currency CurrencyCode { get; set; }

            public decimal Discount { get; set; }

            [Required]
            [DataType(DataType.DateTime)]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public DateTime PaymentDate { get; set; }


            [Required]
            public int BookingId { get; set; }

            [ForeignKey("BookingId")]
            public Booking Booking { get; set; }


            public Payment()
            {
                PaymentDate = DateTime.Now;
            Amount = Amount - (Discount * Amount / 100);
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

