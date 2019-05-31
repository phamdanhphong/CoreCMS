using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CoreCMS.Areas.Admin.Common;
using CoreCMS.Extensions;
using CoreCMS.Models;
using CoreCMS.Utilities.Constants;
using Microsoft.AspNetCore.Mvc;

namespace CoreCMS.Areas.Admin.Components
{
    public class SideBarViewComponent : ViewComponent
    {
        public SideBarViewComponent()
        {

        }


        public IViewComponentResult Invoke(string filter)
        {
            var sidebars = new List<SidebarMenu>();
            sidebars.Add(ModuleHelper.AddModule("Trang chủ", "/admin/home", "fa fa-home"));
            sidebars.Add(ModuleHelper.AddTree("Giới thiệu", "/ItemsAboutUs"));
            sidebars.Last().TreeChild = new List<SidebarMenu>()
            {
               ModuleHelper.AddModule("Quản lý danh mục","/GroupsAboutUs","fa fa-list"),
               ModuleHelper.AddModule("Quản lý danh sách","/ItemsAboutUs","fa fa-list"),
               ModuleHelper.AddModule("Thêm mới danh mục", "/AddGroupsAboutUs","fa fa-plus"),
               ModuleHelper.AddModule("Thêm mới danh sách", "/AddItemsAboutUs","fa fa-plus")
            };
            sidebars.Add(ModuleHelper.AddTree("Tin tức", "/ItemsNews"));
            sidebars.Last().TreeChild = new List<SidebarMenu>()
            {
                ModuleHelper.AddModule("Quản lý danh mục","/GroupsNews","fa fa-list"),
                ModuleHelper.AddModule("Quản lý danh sách","/ItemsNews","fa fa-list"),
                ModuleHelper.AddModule("Thêm mới danh mục", "/AddGroupsNews","fa fa-plus"),
                ModuleHelper.AddModule("Thêm mới danh sách", "/AddItemsNews","fa fa-plus")
            };
            sidebars.Add(ModuleHelper.AddTree("Sản phẩm", "/ItemsProduct"));
            sidebars.Last().TreeChild = new List<SidebarMenu>()
            {
                ModuleHelper.AddModule("Quản lý danh mục","/GroupsProduct","fa fa-list"),
                ModuleHelper.AddModule("Quản lý danh sách","/ItemsProduct","fa fa-list"),
                ModuleHelper.AddModule("Thêm mới danh mục", "/AddGroupsProduct","fa fa-plus"),
                ModuleHelper.AddModule("Thêm mới danh sách", "/AddItemsProduct","fa fa-plus")
            };

            //sidebars.Add(ModuleHelper.AddTree("Đối tác", "fa fa-laptop"));
            //sidebars.Last().TreeChild = new List<SidebarMenu>()
            //{
            //   ModuleHelper.AddModule("Nhà cung cấp",  "/provider"),
            //   ModuleHelper.AddModule("Khách hàng",  "/customer")
            //};

            //sidebars.Add(ModuleHelper.AddTree("Báo cáo", "fa fa-pie-chart"));
            //sidebars.Last().TreeChild = new List<SidebarMenu>()
            //{
            //   ModuleHelper.AddModule("Tài chính",  "/31"),
            //   ModuleHelper.AddModule("Bán hàng",  "/31")
            //};

            //sidebars.Add(ModuleHelper.AddTree("Danh mục", "fa fa-folder"));
            //sidebars.Last().TreeChild = new List<SidebarMenu>()
            //{
            //   ModuleHelper.AddModule("Chức vụ",  "/position"),
            //   ModuleHelper.AddModule("Loại sản phẩm",  "/productcategory")
            //};

            sidebars.Add(ModuleHelper.AddTree("Hệ thống", "fa fa-cog"));
            sidebars.Last().TreeChild = new List<SidebarMenu>()
            {
               ModuleHelper.AddModule("Người dùng",  "/31"),
               ModuleHelper.AddModule("Vai trò",  "/31"),
               ModuleHelper.AddModule("Cấu hình",  "/31")
            };


            var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            if (roles.Split(";").Contains(CommonConstants.AppRole.AdminRole))
            {
                //functions = await _functionService.GetAll(string.Empty);
            }
            else
            {
                //TODO: Get by permission
                //functions = await _functionService.GetAll(string.Empty);
            }

            return View(sidebars);
        }

    }
}
