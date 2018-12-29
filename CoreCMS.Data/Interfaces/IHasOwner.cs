using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCMS.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }
    }
}
