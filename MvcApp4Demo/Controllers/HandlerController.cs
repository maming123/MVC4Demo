﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp4Demo.Controllers
{
    public class HandlerController : Controller
    {
        //
        // GET: /Handler/

        public ActionResult Handler2()
        {
            string s = "bbbbb多几个字母";
            return new ContentResult() { Content="aaaa" };
        }

    }
}
