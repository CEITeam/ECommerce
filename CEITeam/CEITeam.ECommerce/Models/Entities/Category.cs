﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Models
{
    public class Category
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        #region Navigation Properties
        public virtual List<Product> Products { get; set; }
        #endregion
    }
}
