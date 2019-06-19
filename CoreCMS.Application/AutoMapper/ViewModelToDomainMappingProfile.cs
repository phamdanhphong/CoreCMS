using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CoreCMS.Application.ViewModels.Item;
using CoreCMS.Data.Entities;

namespace CoreCMS.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            
            CreateMap<ItemViewModel, Item>();
            CreateMap<GroupViewModel, Group>();

            CreateMap<GroupItemViewModel, GroupItem>();

        }
    }
}
