using CEITeam.ECommerce.Interfaces;
using CEITeam.ECommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.ViewComponents
{
    public class ProfileNavBarViewComponent:ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfileNavBarViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync(string userName)
        {
            ApplicationUser user =userName !=null?_unitOfWork.ApplicationUserManager.GetAll().FirstOrDefault(a => a.UserName == userName):null;
            return  View(user);
        }
    }
}
