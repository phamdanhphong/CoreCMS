using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreCMS.Areas.Admin.Controllers.Product
{
    public class CategoryProductController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}