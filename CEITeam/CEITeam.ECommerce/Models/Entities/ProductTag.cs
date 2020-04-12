using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Models
{
    public class ProductTag
    {

        #region Navigation Properties
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Product")]
        public int Fk_ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Tag")]
        public int Fk_TagtId { get; set; }
        public virtual Tag Tag { get; set; }
        #endregion
    }
}
