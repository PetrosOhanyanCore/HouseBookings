using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Booking
    {
        public int Id { get; set; }

        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public Translation Description { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public string Note { get; set; }

        public DateTime? BookingEndDate { get; set; }


        public DateTime? CancelationDate { get; set; }
        public CancelationReason? CancelationReason { get; set; }
        public Payment Payment { get; set; } // added for Payment 
    }

    public enum CancelationReason
    {
        ByOwner = 1,

        ByUser = 2,

        BySystem = 3
    }
}
