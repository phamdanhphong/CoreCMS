using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreCMS.Application.Interfaces;
using CoreCMS.Application.ViewModels.Item;
using CoreCMS.Data.Entities;
using CoreCMS.Data.Enums;
using CoreCMS.Data.IRepositories;
using CoreCMS.Infrastructure.Interfaces;

namespace CoreCMS.Application.Implementation
{
    public class GroupService:IGroupService
    {

        private IGroupRepository _groupRepository;

        private IUnitOfWork _unitOfWork;

        public GroupService(IGroupRepository groupRepository,IUnitOfWork unitOfWork)
        {
            _groupRepository = groupRepository;
            _unitOfWork = unitOfWork;

        }

        public GroupViewModel Add(GroupViewModel groupViewModel)
        {
            var group = Mapper.Map<GroupViewModel, Group>(groupViewModel);
            _groupRepository.Add(group);
            return groupViewModel;

        }

        public void Update(GroupViewModel groupViewModel)
        {
            var group = Mapper.Map<GroupViewModel, Group>(groupViewModel);
            _groupRepository.Update(group);
        }

        public void Delete(int id)
        {
           _groupRepository.Remove(id);
        }

        public List<GroupViewModel> GetAll()
        {
            return  _groupRepository.FindAll().OrderBy(x=>x.ParentId).ProjectTo<GroupViewModel>().ToList();
        }

        public List<GroupViewModel> GetAll(string app)
        {
            if (!string.IsNullOrEmpty(app))
            {
                return _groupRepository.FindAll(x => x.App.Contains(app)).OrderBy(x => x.ParentId).ProjectTo<GroupViewModel>().ToList();
            }
            else
            {
                return _groupRepository.FindAll().OrderBy(x => x.ParentId).ProjectTo<GroupViewModel>().ToList();
            }
        }

        public List<GroupViewModel> GetAllByParentId(int parentId)
        {
            return _groupRepository.FindAll(x => x.Status == Status.Active && x.ParentId == parentId).ProjectTo<GroupViewModel>().ToList();
        }

       

        public GroupViewModel GetById(int id)
        {
            return Mapper.Map<Group, GroupViewModel>(_groupRepository.FindById(id));
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            var sourceCategory = _groupRepository.FindById(sourceId);
            sourceCategory.ParentId = targetId;
            _groupRepository.Update(sourceCategory);

            //Get all sibling
            var sibling = _groupRepository.FindAll(x => items.ContainsKey(x.Id));
            foreach (var child in sibling)
            {
                child.SortOrder = items[child.Id];
                _groupRepository.Update(child);
            }
        }

        public void ReOrder(int sourceId, int targetId)
        {
            var source = _groupRepository.FindById(sourceId);
            var target = _groupRepository.FindById(targetId);
            int tempOrder = source.SortOrder;
            source.SortOrder = target.SortOrder;
            target.SortOrder = tempOrder;

            _groupRepository.Update(source);
            _groupRepository.Update(target);
        }

       

        public List<GroupViewModel> GetHomeCategories(int top)
        {
            var query = _groupRepository
                .FindAll(x => x.Params1=="1", c => c.Items)
                .OrderBy(x => x.SortOrder)
                .Take(top).ProjectTo<GroupViewModel>();

            var categories = query.ToList();
            foreach (var category in categories)
            {
                //category.Products = _productRepository
                //    .FindAll(x => x.HotFlag == true && x.CategoryId == category.Id)
                //    .OrderByDescending(x => x.DateCreated)
                //    .Take(5)
                //    .ProjectTo<ProductViewModel>().ToList();
            }
            return categories;
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
