﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Freedom.Web.Areas.Admin.Controllers
{
    public class CommonController : Controller
    {
        // GET: Admin/Common
        public ActionResult Index()
        {
            return View();
        }
    }
}