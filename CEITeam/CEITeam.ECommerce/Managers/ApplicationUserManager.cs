using CEITeam.ECommerce.Data;
using CEITeam.ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Managers
{
    public class ApplicationUserManager : Repository<ApplicationUser, DbContext>
    {
        public ApplicationUserManager(ApplicationDbContext context) : base(context)
        {

        }
    }
}
