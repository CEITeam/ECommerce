using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(256)]
        public string Address { get; set; }

        [MaxLength(256)]
        public string ImageUrl { get; set; }

        #region Navigation Properties
        [ForeignKey("Customer")]
        public int? Fk_CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Brand")]
        public int? Fk_BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        #endregion
    }
}
