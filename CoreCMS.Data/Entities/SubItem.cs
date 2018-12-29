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
    [Table("SubItems")]
    public class SubItem:DomainEntity<int>,IDateTracking,ISoftable,ISwichtable,IMultiLanguage<int>
    {
        [Required]
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        public virtual Item Item { set; get; }
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public int LanguageId { get; set; }
        [StringLength(255)]
        public string  App { get; set; }
        [StringLength(255)]
        public string Key { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string Email { get; set; }
        [StringLength(1000)]
        public string Author { get; set; }
        [StringLength(1000)]
        public string Url { get; set; }

        public string Params1 { get; set; }
        public string Params2 { get; set; }
        public string Params3 { get; set; }
        public string Params4 { get; set; }
        public string Params5 { get; set; }

        public int Iparams1 { get; set; }
        public int Iparams2 { get; set; }
        public int Iparams3 { get; set; }
        public int Iparams4 { get; set; }
        public int Iparams5 { get; set; }


        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<Item> Items { set; get; }
       
    }
}
