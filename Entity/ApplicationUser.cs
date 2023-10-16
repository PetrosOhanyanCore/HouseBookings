using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DeactivationDate { get; set; }

        public string AccessToken { get; set; }

        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
