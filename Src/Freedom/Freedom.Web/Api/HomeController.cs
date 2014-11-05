using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Freedom.Web.Api
{
    public class HomeController : ApiController
    {
        public int Get()
        {
            return 1;
        }
    }
}
