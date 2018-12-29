using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Infrastructure.SharedKernel;

namespace CoreCMS.Data.Entities
{
    [Table("Roles")]
    public class Role : DomainEntity<int>
    {
        [StringLength(100)]
        public string RoleName { get; set; }
        [StringLength(300)]
        public string RoleDescription { get; set; }


        public int RoleLevel { set; get; }
    }
}
