using System;
using System.Collections.Generic;
using System.Text;
using CoreCMS.Application.ViewModels.Item;
using CoreCMS.Data.Entities;
using CoreCMS.Utilities.Dtos;

namespace CoreCMS.Application.Interfaces
{
    public interface IGroupItemService
    {
        List<GroupItemInfo> GetAll(string app);
       
        PagedResult<GroupItemInfo> GetAllPaging(string app, int? groupId, string keyword, int page, int pageSize);

    }
}
