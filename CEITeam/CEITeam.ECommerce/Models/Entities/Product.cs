using CEITeam.ECommerce.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(512)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(0, float.MaxValue)]
        public float UnitPrice { get; set; }

        [Required]
        [Range(0, 100)]
        public int Discount { get; set; }
        
        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        [Required]
        public ProductStatus Status { get; set; }    

        [Required]
        public PaymentType PaymentType { get; set; }

        public DateTime PublishedDate { get; set; }

        [MaxLength(256)]
        public string ImageUrl { get; set; }

        #region Navigation Properties
        //[ForeignKey("Category")]
        //public int Fk_CategoryId { get; set; }
        //public virtual Category Category { get; set; }

        //[ForeignKey("Brand")]
        //public int? Fk_BrandId { get; set; }
        //public virtual Brand Brand { get; set; }
        #endregion

    }
}
