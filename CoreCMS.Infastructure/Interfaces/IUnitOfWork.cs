using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCMS.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {/// <summary>
    /// Call savechange from db Context
    /// </summary>
        void Commit();

    }
}
