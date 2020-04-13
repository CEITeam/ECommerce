using CEITeam.ECommerce.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Interfaces
{
    public interface IUnitOfWork
    {
        ApplicationUserManager ApplicationUserManager { get; }
        ProductManager ProductManager { get; }
        CategoryManager CategoryManager { get; }
        TagManager TagManager { get; }
        BrandManager BrandManager { get; }
        CustomerManager CustomerManager { get; }
        OrderManger OrderManger { get; }
        ProductTagManager ProductTagManager { get; }

    }
}
