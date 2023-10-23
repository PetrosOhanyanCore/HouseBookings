using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public ApartmentDTO Apartment { get; set; }
        /*public BuildingDTO Building { get; set; }
        public ClientDTO Client { get; set; }*/
        public PaymentDTO Payment { get; set; }
        public Translation Description { get; set; }
        public string Note { get; set; }
        public DateTime? BookingEndDate { get; set; }
        public DateTime? CancelationDate { get; set; }
        public CancelationReason? CancelationReason { get; set; }
    }
}
