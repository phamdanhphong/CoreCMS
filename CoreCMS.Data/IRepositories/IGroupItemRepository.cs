using System;
using System.Collections.Generic;
using System.Text;
using CoreCMS.Data.Entities;
using CoreCMS.Infrastructure.Interfaces;
using CoreCMS.Utilities.Dtos;

namespace CoreCMS.Data.IRepositories
{
    public interface IGroupItemRepository : IRepository<GroupItem, int>
    {
        List<GroupItemInfo> GetAll(string app);
        PagedResult<GroupItemInfo> GetAllPaging(string app, int? groupId, string key, int page, int pageSize);

    }
}
