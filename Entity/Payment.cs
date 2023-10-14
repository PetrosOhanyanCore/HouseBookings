<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        [StringLength(16)]
        public int CardNumber { get; set; }

        [Required]
        public string CardOwner { get; set; }

        [MaxLength(3)]
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
        GBP, // Funt-Sterling
        JPY, // Japan Iyen
                // others
    }
=======
﻿using System;
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
>>>>>>> 2668f49597539e11d7fa083754587ae77b9dcb30
}

