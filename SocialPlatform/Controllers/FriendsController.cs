﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialPlatform.Controllers
{
    public class FriendsController : Controller
    {
        // GET: Friends
        public  ActionResult Index()
        {
            return View();
        }
    }
}