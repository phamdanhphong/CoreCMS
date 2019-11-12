using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreCMS.Areas.Admin.Controllers.Product.ItemProduct
{
    public class ItemProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}