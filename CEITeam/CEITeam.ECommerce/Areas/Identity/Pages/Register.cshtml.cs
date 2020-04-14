using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using CEITeam.ECommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using CEITeam.ECommerce.Interfaces;
using CEITeam.ECommerce.Models.ViewModels;

namespace CEITeam.ECommerce.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private IUnitOfWork _unitOfWork;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IUnitOfWork unitOfWork)


        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _unitOfWork = unitOfWork;


        }

        [BindProperty]
        public BrandInputModel BrandInput { get; set; }
        [BindProperty]
        public CustomerInputModel CustomerInput { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }


        public async Task OnGetAsync(string returnUrl = null)
        {
            //IdentityRole admin = new IdentityRole("Admin");
            //IdentityRole brand = new IdentityRole("Brand");
            //IdentityRole customer = new IdentityRole("Customer");
            //await _roleManager.CreateAsync(admin);
            //await _roleManager.CreateAsync(brand);
            //await _roleManager.CreateAsync(customer);

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (BrandInput.Website != null)
            {

                var user = new ApplicationUser { UserName = BrandInput.UserName, Email = BrandInput.Email, Address = BrandInput.Address, PhoneNumber = BrandInput.Phone };
                var result = await _userManager.CreateAsync(user, BrandInput.Password);
                if (result.Succeeded)
                {
                    var brand = new Brand { Name = BrandInput.Name, Website = BrandInput.Website, Fk_ApplicationUserId = user.Id };
                    _unitOfWork.BrandManager.Add(brand);
                    user.Fk_BrandId = brand.Id;
                    await _userManager.AddToRoleAsync(user, "Brand");
                    await _userManager.UpdateAsync(user);
                    await _signInManager.SignInAsync(user, isPersistent: false);

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            else
            {
                var user = new ApplicationUser { UserName = CustomerInput.UserName, Email = CustomerInput.Email, Address = CustomerInput.Address, PhoneNumber = CustomerInput.Phone };
                var result = await _userManager.CreateAsync(user, CustomerInput.Password);
                if (result.Succeeded)
                {
                    var customer = new Customer { FirstName = CustomerInput.FirstName, LastName = CustomerInput.LastName, Fk_ApplicationUserId = user.Id };
                    _unitOfWork.CustomerManager.Add(customer); //use manager
                    user.Fk_CustomerId = customer.Id;
                    await _userManager.AddToRoleAsync(user, "Customer");
                    await _userManager.UpdateAsync(user);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
