using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreCMS.Data.Entities;
using CoreCMS.Data.IRepositories;

namespace CoreCMS.Data.EF.Repositories
{
    public class ItemRepository : EFRepository<Item,int> ,IItemsRepository
    {
        private AppDbContext _context;
        public ItemRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

       public List<Item> GetBySeoTitle(string seoAlias)
       {
           return _context.Items.Where(x => x.SeoAlias == seoAlias).ToList();
       }
    }
}
