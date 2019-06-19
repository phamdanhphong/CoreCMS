using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CoreCMS.Application.ViewModels.Item;
using CoreCMS.Data.Entities;

namespace CoreCMS.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Group,GroupViewModel>();
            CreateMap<Item, ItemViewModel>();
            CreateMap<GroupItem, GroupItemViewModel>();
        }
    }
}
