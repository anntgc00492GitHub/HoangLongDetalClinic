using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HoangLongDetalClinic.Web.CustomFilters;

namespace HoangLongDetalClinic.Web.Areas.Admin.Controllers
{
    [AuthLog(Roles = "Customer")]
    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class CustomerController : Controller
    {
        // GET: Admin/Customer
        public ActionResult Index()
        {
            return View();
        }
    }
}