using System;
using System.Collections.Generic;
using System.Text;
using CoreCMS.Data.Enums;

namespace CoreCMS.Data.Interfaces
{
    public interface ISwichtable
    {
        Status Status { set; get; }
    }
}
