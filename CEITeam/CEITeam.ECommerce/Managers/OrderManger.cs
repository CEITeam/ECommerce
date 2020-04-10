using CEITeam.ECommerce.Data;
using CEITeam.ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Managers
{
    public class OrderManger : Repository<Order, ApplicationDbContext>
    {
        public OrderManger(ApplicationDbContext context) : base(context)
        {

        }
    }
}
