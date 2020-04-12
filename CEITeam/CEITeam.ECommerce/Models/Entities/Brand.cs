using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Website { get; set; }

        #region Navigation Properties
        //public virtual List<Product> Products { get; set; }

        ////------Updated 12/4/2020------
        //[ForeignKey("ApplicationUser")]
        //public string Fk_ApplicationUserId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }
        #endregion
    }
}
