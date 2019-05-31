using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCMS.Models;

namespace CoreCMS.Areas.Admin.Common
{
    public static class ModuleHelper
    {
        public static SidebarMenu AddHeader(string name)
        {
            return new SidebarMenu
            {
                Type = SidebarMenuType.Header,
                Name = name,
            };
        }

        public static SidebarMenu AddTree(string name, string uRLPath="", string iconClassName = "fa fa-bars")
        {
            return new SidebarMenu
            {
                Type = SidebarMenuType.Tree,
                IsActive = false,
                Name = name,
                IconClassName = iconClassName,
                URLPath = "#",
            };
        }

        public static SidebarMenu AddModule(string name, string uRLPath, string iconClassName = "", Tuple<int, int, int> counter = null)
        {
            if (counter == null)
                counter = Tuple.Create(0, 0, 0);

            return new SidebarMenu
            {
                Type = SidebarMenuType.Link,
                Name = name,
                IconClassName = iconClassName,
                URLPath = uRLPath,
                LinkCounter = counter,
            };
        }
    }
}
