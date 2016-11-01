using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HoangLongDetalClinic.Web.CustomFilters;

namespace HoangLongDetalClinic.Web.Areas.Admin.Controllers
{
    [AuthLog(Roles = "Admin")]
    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}