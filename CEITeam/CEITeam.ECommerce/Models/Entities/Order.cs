using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Models
{
    public class Order
    {
        [Range(1, 100)]
        public int Quantity { get; set; }

        public DateTime OrderedDate { get; set; }

        #region Navigation Property
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Product")]
        public int Fk_ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Customer")]
        public int Fk_CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        #endregion


    }
}
