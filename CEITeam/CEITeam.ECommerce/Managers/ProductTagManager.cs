using CEITeam.ECommerce.Data;
using CEITeam.ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Managers
{
    public class ProductTagManager : Repository<ProductTag, ApplicationDbContext>
    {
        public ProductTagManager(ApplicationDbContext context) : base(context)
        {

        }
    }
}
