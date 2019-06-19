using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper.QueryableExtensions;
using CoreCMS.Application.Interfaces;
using CoreCMS.Application.ViewModels.Item;
using CoreCMS.Data.Entities;
using CoreCMS.Data.Enums;
using CoreCMS.Data.IRepositories;
using CoreCMS.Infrastructure.Interfaces;
using CoreCMS.Utilities.Dtos;

namespace CoreCMS.Application.Implementation
{
    public class GroupItemService : IGroupItemService
    {
        private IGroupItemRepository _groupItemRepository;
        private IItemsRepository _itemsRepository;
        private IGroupRepository _groupRepository;

        public GroupItemService(IGroupItemRepository groupItemRepository, IItemsRepository itemsRepository, IGroupRepository groupRepository)
        {
            _groupItemRepository = groupItemRepository;
            _itemsRepository = itemsRepository;
            _groupRepository = groupRepository;
        }


        public List<GroupItemInfo> GetAll(string app)
        {
            return _groupItemRepository.GetAll(app);
        }

        public PagedResult<GroupItemInfo> GetAllPaging(string app, int? groupId, string keyword, int page, int pageSize)
        {
            return _groupItemRepository.GetAllPaging(app, groupId, keyword, page, pageSize);
        }

        
    }
}
