using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClientUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DeactivationDate { get; set; }
        //public Residence { get; set; }
        //public Rating { get; set; }
        //public Image { get; set; }
        //public PaymentType { get; set; }
    }
}
