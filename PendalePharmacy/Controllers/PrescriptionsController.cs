﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PendalePharmacy.Controllers
{
    public class PrescriptionsController : Controller
    {
        // GET: Prescriptions
        public ActionResult Index()
        {
            return View();
        }
    }
}