using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Infrastructure.SharedKernel;

namespace CoreCMS.Data.Entities
{
    [Table("Members")]
    public class Members : DomainEntity<int>
    {
        [StringLength(255)]
        public string Property { get; set; }
        [StringLength(255)]
        public string Account { get; set; }
        [StringLength(255)]
        public string Password { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
       
        public DateTime Birthday { get; set; }
        [StringLength(255)]
        public string IdentityCard { get; set; }
        [StringLength(255)]
        public string Relationship { get; set; }
        [StringLength(255)]
        public string Edu { get; set; }
        [StringLength(255)]
        public string Job { get; set; }
        [StringLength(255)]
        public string YahooNick { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(255)]
        public string PasswordQuestion { get; set; }
        [StringLength(255)]
        public string PasswordAnswer { get; set; }
        public int IsApproved { get; set; }
        public int IsLockedOut { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastChangePasswordDate { get; set; }
        public DateTime LastLogOutDate { get; set; }
        public string Comment { get; set; }
        public int TotalLogin { get; set; }
        public int Totalview { get; set; }
        [StringLength(255)]
        public string Weight { get; set; }
        [StringLength(255)]
        public string Height { get; set; }

        [StringLength(255)]
        public string Blast { get; set; }

    }
}
