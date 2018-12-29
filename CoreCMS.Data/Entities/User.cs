using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Infrastructure.SharedKernel;

namespace CoreCMS.Data.Entities
{
    [Table("Users")]
    public class User : DomainEntity<int>
    {
        public int RoleId { get; set; }
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string UserPassword { get; set; }

        [StringLength(100)]
        public string UserFirstName { get; set; }
        [StringLength(100)]
        public string UserLastName { get; set; }
        [StringLength(500)]
        public string UserAddress { get; set; }
        [StringLength(100)]
        public string UserPhoneNumber { get; set; }
        [StringLength(300)]
        public string UserEmail { get; set; }
        [StringLength(100)]
        public string UserIdentityCard { get; set; }
        [StringLength(500)]
        public string UserPasswordQuestion { get; set; }
        [StringLength(500)]
        public string UserPasswordAnswer { get; set; }
        public int UserIsApproved { get; set; }
        public int UserIsLockedout { get; set; }
        public DateTime UserLastPasswordChangedDate { get; set; }
        public DateTime UserLastLockoutDate { get; set; }
        public string UserComment { get; set; }
        public string Params1 { get; set; }
        public string Params2 { get; set; }
        public string Params3 { get; set; }
        public string Params4 { get; set; }
        public string Params5 { get; set; }
        public DateTime UserCreateDate { get; set; }
        public DateTime UserLastLogindate { get; set; }

    }
}
