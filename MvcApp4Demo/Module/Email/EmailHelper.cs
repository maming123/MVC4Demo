﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp4Demo.Module.Email
{
    public class EmailHelper:IEmailHelper
    {

        #region IEmailHelper 成员

        public string SendEmail()
        {
            return "EmailHelper.SendEmail Method,SendEmail OK!!";
            //throw new NotImplementedException();
        }

        #endregion
    }
}