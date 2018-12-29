using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Data.Enums;
using CoreCMS.Data.Interfaces;
using CoreCMS.Infrastructure.SharedKernel;

namespace CoreCMS.Data.Entities
{
    [Table("Groups_Items")]
    public class GroupItem : DomainEntity<int>,IDateTracking,ISwichtable
    {

        [Required]
        public int GroupId { get; set; }

        [Required]
        public int ItemId { get; set; }


        [ForeignKey("GroupId")]
        public virtual Group Group { set; get; }


        [ForeignKey("ItemId")]
        public virtual Item Item { set; get; }
       
        public virtual ICollection<Group> Groups { set; get; }
        public virtual ICollection<Item> Items { set; get; }
        public  string  Params { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}
