using Freedom.Services.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Freedom.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICustomerService _customerService;
        public AccountController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View();
        }
    }
}