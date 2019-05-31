using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreCMS.Data.Entities;
using CoreCMS.Data.IRepositories;

namespace CoreCMS.Data.EF.Repositories
{
    public class GroupRepository:EFRepository<Group,int> ,IGroupRepository
    {
        private AppDbContext _context;
        public GroupRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

       public List<Group> GetBySeoTitle(string seoAlias)
       {
           return _context.Groups.Where(x => x.SeoAlias == seoAlias).ToList();
       }
    }
}
