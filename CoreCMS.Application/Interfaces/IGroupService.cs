using System;
using System.Collections.Generic;
using System.Text;
using CoreCMS.Application.ViewModels.Item;

namespace CoreCMS.Application.Interfaces
{
    public interface IGroupService
    {
        GroupViewModel Add(GroupViewModel groupViewModel);
        void Update(GroupViewModel groupViewModel);
        void Delete(int id);
        List<GroupViewModel> GetAll();
        List<GroupViewModel> GetAll(string keyword);
        List<GroupViewModel> GetAllByParentId(int parentId);
        GroupViewModel GetById(int id);
        void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items);
        void ReOrder(int sourceId, int targetId);
        List<GroupViewModel> GetHomeCategories(int top);
        void Save();
    }
}
