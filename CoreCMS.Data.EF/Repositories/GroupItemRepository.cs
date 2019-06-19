using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreCMS.Data.Entities;
using CoreCMS.Data.Enums;
using CoreCMS.Data.IRepositories;
using CoreCMS.Utilities.Dtos;

namespace CoreCMS.Data.EF.Repositories
{
    public class GroupItemRepository : EFRepository<GroupItem, int>, IGroupItemRepository
    {
        private AppDbContext _context;
        public GroupItemRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<GroupItemInfo> GetAll(string app)
        {
            var query = from a in _context.GroupItems
                join b in _context.Items on a.ItemId equals b.Id into temp
                from tblItem in temp.DefaultIfEmpty()
                join c in _context.Groups on a.GroupId equals c.Id into temp2
                from tblGroup in temp2.DefaultIfEmpty()
                        select new GroupItemInfo()
                        {

                            //Item
                            ItemId = tblItem.Id,
                            ItemLanguageId = tblItem.LanguageId,
                            Title = tblItem.Name,
                            Key = tblItem.Key,
                            App = tblItem.App,
                            Description = tblItem.Description,
                            Content = tblItem.Content,
                            Image = tblItem.Image,
                            Url = tblItem.Url,
                            Author = tblItem.Author,
                            Price = tblItem.Price,
                            SalesPrice = tblItem.SalesPrice,
                            SeoPageTitle = tblItem.SeoPageTitle,
                            SeoAlias = tblItem.SeoAlias,
                            SeoKeywords = tblItem.SeoKeywords,
                            SeoDescription = tblItem.SeoDescription,
                            Params1 = tblItem.Params1,
                            Params2 = tblItem.Params2,
                            Params3 = tblItem.Params3,
                            Params4 = tblItem.Params4,
                            Params5 = tblItem.Params5,
                            SortOrder = tblItem.SortOrder,
                            TotalView = tblItem.TotalView,
                            DateCreated = tblItem.DateCreated,
                            DateModified = tblItem.DateModified,
                            ItemStatus = tblItem.Status,
                            //Group
                            GroupId = a.GroupId,
                            GroupName = tblGroup.Name,
                            GroupLanguageId = tblGroup.LanguageId,
                            GroupApp = tblGroup.App,
                            Level = tblGroup.Level,
                            ParentId = tblGroup.ParentId,
                            ParentsId = tblGroup.ParentsId,
                            GroupDescription = tblGroup.Description,
                            GroupContent = tblGroup.Content,
                            GroupSeoPageTitle = tblGroup.SeoPageTitle,
                            GroupSeoAlias = tblGroup.SeoAlias,
                            GroupSeoKeywords = tblGroup.SeoKeywords,
                            GroupSeoDescription = tblGroup.SeoDescription,
                            GroupParams1 = tblGroup.Params1,
                            GroupParams2 = tblGroup.Params2,
                            GroupParams3 = tblGroup.Params3,
                            GroupParams4 = tblGroup.Params4,
                            GroupParams5 = tblGroup.Params5,
                            GroupIparams1 = tblGroup.Iparams1,
                            GroupIparams2 = tblGroup.Iparams2,
                            GroupIparams3 = tblGroup.Iparams3,
                            GroupIparams4 = tblGroup.Iparams4,
                            GroupIparams5 = tblGroup.Iparams5,
                            GroupDateCreated = tblGroup.DateCreated,
                            GroupDateModified = tblGroup.DateModified,
                            GroupStatus = tblGroup.Status

                        };
            if (!String.IsNullOrEmpty(app))
            {
                query = query.Where(x => x.App.Contains(app) && x.GroupApp.Contains(app) && x.ItemStatus==Status.Active && x.GroupStatus == Status.Active).OrderBy(x => x.DateCreated);
            }

            return query.ToList();

        }

        public PagedResult<GroupItemInfo> GetAllPaging(string app, int? groupId, string keyword, int page, int pageSize)
        {
            var query = from a in _context.GroupItems
                join b in _context.Items on a.ItemId equals b.Id into temp
                from tblItem in temp.DefaultIfEmpty()
                join c in _context.Groups on a.GroupId equals c.Id into temp2
                from tblGroup in temp2.DefaultIfEmpty()
                select new GroupItemInfo()
                {
                    //Item
                    ItemId = tblItem.Id,
                    ItemLanguageId = tblItem.LanguageId,
                    Title = tblItem.Name,
                    Key = tblItem.Key,
                    App = tblItem.App,
                    Description = tblItem.Description,
                    Content = tblItem.Content,
                    Image = tblItem.Image,
                    Url=tblItem.Url,
                    Author = tblItem.Author,
                    Price = tblItem.Price,
                    SalesPrice = tblItem.SalesPrice,
                    SeoPageTitle = tblItem.SeoPageTitle,
                    SeoAlias = tblItem.SeoAlias,
                    SeoKeywords = tblItem.SeoKeywords,
                    SeoDescription = tblItem.SeoDescription,
                    Params1 = tblItem.Params1,
                    Params2 = tblItem.Params2,
                    Params3 = tblItem.Params3,
                    Params4 = tblItem.Params4,
                    Params5 = tblItem.Params5,
                    SortOrder = tblItem.SortOrder,
                    TotalView = tblItem.TotalView,
                    DateCreated = tblItem.DateCreated,
                    DateModified = tblItem.DateModified,
                    ItemStatus = tblItem.Status,
                    //Group
                    GroupId = a.GroupId,
                    GroupName = tblGroup.Name,
                    GroupLanguageId = tblGroup.LanguageId,
                    GroupApp = tblGroup.App,
                    Level = tblGroup.Level,
                    ParentId = tblGroup.ParentId,
                    ParentsId = tblGroup.ParentsId,
                    GroupDescription  = tblGroup.Description,
                    GroupContent = tblGroup.Content,
                    GroupSeoPageTitle = tblGroup.SeoPageTitle,
                    GroupSeoAlias = tblGroup.SeoAlias,
                    GroupSeoKeywords = tblGroup.SeoKeywords,
                    GroupSeoDescription = tblGroup.SeoDescription,
                    GroupParams1 = tblGroup.Params1,
                    GroupParams2 = tblGroup.Params2,
                    GroupParams3 = tblGroup.Params3,
                    GroupParams4 = tblGroup.Params4,
                    GroupParams5 = tblGroup.Params5,
                    GroupIparams1 = tblGroup.Iparams1,
                    GroupIparams2 = tblGroup.Iparams2,
                    GroupIparams3 = tblGroup.Iparams3,
                    GroupIparams4 = tblGroup.Iparams4,
                    GroupIparams5 = tblGroup.Iparams5,
                    GroupDateCreated = tblGroup.DateCreated,
                    GroupDateModified = tblGroup.DateModified,
                    GroupStatus = tblGroup.Status
                   
                };

           

            if (!String.IsNullOrEmpty(app))
            {
                query = query.Where(x => x.App.Contains(app) && x.GroupApp.Contains(app));
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Title.Contains(keyword));
            }

            if (groupId.HasValue)
            {
                query = query.Where(x => x.GroupId == groupId.Value);
            }

            int totalRow = query.Count();
            query = query.Where(x => x.ItemStatus == Status.Active && x.GroupStatus == Status.Active).OrderByDescending(x => x.DateCreated).Skip((page - 1) * pageSize).Take(pageSize);
            var data = query.ToList();
            var paginationSet = new PagedResult<GroupItemInfo>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;

        }

    }
}
