using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        #region Navigation Properties
        ////updated ------12/4---------
        public virtual List<ProductTag> ProductsTag { get; set; }
        #endregion
    }
}
