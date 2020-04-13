using CEITeam.ECommerce.Data;
using CEITeam.ECommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Managers
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        private ApplicationUserManager applicationUserManager;
        private CustomerManager customerManager;
        private BrandManager brandManager;
        private ProductManager productManager;
        private TagManager tagManager;
        private CategoryManager categoryManager;
        private OrderManger orderManger;
        private ProductTagManager productTagManager;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;

        }

        public ApplicationUserManager ApplicationUserManager
        {
            get
            {
                applicationUserManager = applicationUserManager ?? new ApplicationUserManager(context);
                return applicationUserManager;
            }
        }
        public ProductManager ProductManager
        {
            get
            {
                productManager = productManager ?? new ProductManager(context);
                return productManager;
            }
        }
        public CategoryManager CategoryManager
        {
            get
            {
                categoryManager = categoryManager ?? new CategoryManager(context);
                return categoryManager;
            }
        }
        public TagManager TagManager
        {
            get
            {
                tagManager = tagManager ?? new TagManager(context);
                return tagManager;
            }
        }
        public BrandManager BrandManager
        {
            get
            {
                brandManager = brandManager ?? new BrandManager(context);
                return brandManager;
            }
        }
        public CustomerManager CustomerManager
        {
            get
            {
                customerManager = customerManager ?? new CustomerManager(context);
                return customerManager;
            }
        }

        public OrderManger OrderManger
        {
            get
            {
                orderManger = orderManger ?? new OrderManger(context);
                return orderManger;
            }
        }

        public ProductTagManager ProductTagManager
        {
            get
            {
                productTagManager = productTagManager ?? new ProductTagManager(context);
                return productTagManager;
            }
        }


    }
}
