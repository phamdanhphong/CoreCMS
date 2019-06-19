using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCMS.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoreCMS.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private IGroupItemService _groupItemService;
        private IGroupService _groupService;

        public IActionResult ItemsProduct() // hiện thị danh sách sản phẩm
        {
            return View();
        }

        public ProductController(IGroupItemService groupItemService, IGroupService groupService)
        {
            _groupItemService = groupItemService;
            _groupService = groupService;
        }

        #region AJAX API
        [HttpGet]
        public IActionResult GetItemByApp(string app)
        {
            var model = _groupItemService.GetAll("P");

            return new OkObjectResult(model);
        }


        public IActionResult GetAllProductCate(string app)
        {
            var model = _groupService.GetAll("P");

            return new OkObjectResult(model);
        }

        public IActionResult GetAllPagingByApp(string app, int? groupId, string keyword, int page, int pageSize)
        {
            var model = _groupItemService.GetAllPaging(app, groupId, keyword, page, pageSize);

            return new OkObjectResult(model);
        }


        #endregion
    }
}