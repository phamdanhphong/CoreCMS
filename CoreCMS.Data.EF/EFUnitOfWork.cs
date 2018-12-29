using System;
using System.Collections.Generic;
using System.Text;
using CoreCMS.Infrastructure.Interfaces;

namespace CoreCMS.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext _context;


        public EFUnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
           _context.Dispose();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
